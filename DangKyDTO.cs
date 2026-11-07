namespace Lab12.DTO
{
    // DTO thuan tuy: khong tham chieu WinForms/ADO.NET, chi mang du lieu giua cac tang.
    public class DangKyDTO
    {
        public string MaSV { get; set; }
        public string MaHP { get; set; }
        public int HocKy { get; set; }
        public decimal? Diem { get; set; } // cho phep null (chua co diem)

        // Chi dung de hien thi (khong luu CSDL), nap kem khi doc danh sach qua JOIN
        public string TenHP { get; set; }
        public int SoTinChi { get; set; }
    }
}
