LAB 12 - MASTER-DETAIL, TRANSACTION VA HOAN THIEN MO HINH 3 LOP
====================================================================

1. CHUAN BI TRUOC KHI CHAY
----------------------------
- Da co database QLSinhVien, bang Khoa va SinhVien (tu Lab 7/8/9/11).
- QUAN TRONG: mo file tao_bang_HocPhan_DangKy.sql bang SSMS, chay script
  do TRUOC (dang o database QLSinhVien). Script nay tao 2 bang con thieu:
  HocPhan va DangKy, kem du lieu mau. De bai nhac nen sao luu database
  truoc khi chay (de thu rollback/xung dot an toan).
- Neu Lab 11 chua chay script tao Stored Procedure (sp_SinhVien_CRUD.sql)
  thi khong anh huong Lab 12, vi Lab 12 dung lenh INSERT thuong trong
  transaction, khong goi lai cac Stored Procedure do.
- Mo Lab12.DAL/DbConnectionFactory.cs, kiem tra chuoi "Data Source=..."
  dung voi server SQL Server tren may ban.

2. CACH CHAY
-------------
- Mo Lab12_MasterDetail_Transaction.sln bang Visual Studio 2022.
- Dat Lab12.GUI lam Startup Project.
- Nhan F5. Form co 2 tab.

3. CAU TRUC PROJECT (kien truc DTO - DAL - BUS - GUI)
---------------------------------------------------------
- Lab12.DTO : SinhVienDTO, KhoaDTO, HocPhanDTO, DangKyDTO.
- Lab12.DAL : DbConnectionFactory, SinhVienDAL, KhoaDAL, HocPhanDAL,
  DangKyDAL. Cac phuong thuc Insert/InsertEnrollment co ban nhan
  SqlConnection + SqlTransaction tu ben ngoai (bai 5).
- Lab12.BUS : SinhVienBUS, DangKyBUS, KhoaBUS, HocPhanBUS. Noi dieu phoi
  giao dich (mo Connection, BeginTransaction, goi nhieu DAL, Commit/
  Rollback) - khong phu thuoc control WinForms.
- Lab12.GUI : frmMasterDetail - 2 tab, chi goi BUS, khong viet SQL.

4. NOI DUNG TUNG BAI (1 - 5, co huong dan)
---------------------------------------------
Tab "1-2. Master-Detail":
  Bai 1 - Giao dien master-detail Khoa - SinhVien:
    Chon 1 dong o luoi Khoa (ben trai) -> luoi Sinh vien (giua) tu dong
    loc chi hien sinh vien thuoc khoa do.

  Bai 2 - Master-detail SinhVien - Dang ky hoc phan:
    Chon tiep 1 dong o luoi Sinh vien -> luoi Dang ky (duoi) hien cac
    hoc phan sinh vien do da dang ky (dung JOIN de lay Ten hoc phan).
    O duoi cung co the chon 1 Hoc phan + Hoc ky roi bam "Them dang ky"
    de them ngay 1 dang ky moi cho sinh vien dang chon (minh hoa lai
    phuong thuc DAL nhan Connection/Transaction cua bai 5, duoc tai su
    dung cho ca giao dich 1 buoc nay).

Tab "3-5. Transaction":
  Bai 3 - Transaction them sinh vien va dang ky:
    Nhap thong tin Sinh vien moi (ben trai) + lan luot "Them" tung hoc
    phan muon dang ky ban dau vao danh sach cho duyet (ben phai, chua
    luu CSDL). Bam "Luu (Transaction)": toan bo INSERT sinh vien + cac
    INSERT dang ky duoc thuc hien trong 1 SqlTransaction duy nhat, chi
    Commit khi tat ca thanh cong.

  Bai 4 - Mo phong loi va kiem chung Rollback:
    Tick o "Gia lap loi" truoc khi bam "Luu (Transaction)": ung dung se
    tu dong chen them 1 ma hoc phan khong ton tai ("KHONGTONTAI") vao
    cuoi danh sach dang ky, gay loi vi pham khoa ngoai -> toan bo giao
    dich Rollback. Khung ket qua phia duoi se bao ro "That bai va da
    Rollback", dong thoi tu kiem tra va hien sinh vien co con ton tai
    trong CSDL hay khong (phai la KHONG neu rollback dung). Co the bam
    rieng nut "Kiem tra SV da duoc luu chua" bat ky luc nao de kiem tra
    doc lap theo Ma SV dang nhap.

  Bai 5 - Hoan thien lop DAL dung transaction:
    SinhVienDAL.Insert(dto, conn, tx) va DangKyDAL.InsertEnrollment(dto,
    conn, tx) deu nhan SqlConnection/SqlTransaction tu ben ngoai (khong
    tu mo ket noi rieng). Tang BUS (SinhVienBUS.AddStudentWithEnrollments,
    DangKyBUS.AddEnrollment) la noi dieu phoi: mo Connection, BeginTransaction,
    goi lan luot cac ham DAL nay, Commit hoac Rollback. DAL chi lo
    thuc thi cau lenh, khong tu quyet dinh Commit/Rollback.

5. DU LIEU THU
---------------
Dung lai database QLSinhVien tu cac lab truoc, co them 2 bang HocPhan/
DangKy (sau khi chay script o Buoc 1). De kiem tra ro bai 4, nen thu
Luu giao dich 1 lan KHONG tick "Gia lap loi" (thanh cong), roi thu lai
1 lan CO tick (that bai + rollback) de so sanh.

6. GHI CHU
-----------
- Cac bai 6-10 (tu thuc hien) chua lam trong lan nop nay.
- Neu quen chay tao_bang_HocPhan_DangKy.sql truoc, app se bao loi
  "Invalid object name 'HocPhan'" hoac 'DangKy' - quay lai Buoc 1.
