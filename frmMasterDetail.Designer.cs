namespace Lab12.GUI
{
    partial class frmMasterDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabMain = new System.Windows.Forms.TabControl();
            this.lblTrangThai = new System.Windows.Forms.Label();

            // ---- Tab 1 ----
            this.tabMasterDetail = new System.Windows.Forms.TabPage();

            this.grpKhoa = new System.Windows.Forms.GroupBox();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.colKhoaMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.grpSinhVien = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colSvMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSvDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.grpDangKy = new System.Windows.Forms.GroupBox();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.colDkMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDkTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDkSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDkHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDkDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHocPhanThem = new System.Windows.Forms.Label();
            this.cboHocPhanThem = new System.Windows.Forms.ComboBox();
            this.lblHocKyThem = new System.Windows.Forms.Label();
            this.txtHocKyThem = new System.Windows.Forms.TextBox();
            this.btnThemDangKy = new System.Windows.Forms.Button();

            // ---- Tab 2 ----
            this.tabTransaction = new System.Windows.Forms.TabPage();

            this.grpSinhVienMoi = new System.Windows.Forms.GroupBox();
            this.lblMaSV2 = new System.Windows.Forms.Label();
            this.txtMaSV2 = new System.Windows.Forms.TextBox();
            this.lblHoTen2 = new System.Windows.Forms.Label();
            this.txtHoTen2 = new System.Windows.Forms.TextBox();
            this.lblNgaySinh2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh2 = new System.Windows.Forms.DateTimePicker();
            this.radNam2 = new System.Windows.Forms.RadioButton();
            this.radNu2 = new System.Windows.Forms.RadioButton();
            this.lblKhoa2 = new System.Windows.Forms.Label();
            this.cboKhoa2 = new System.Windows.Forms.ComboBox();
            this.lblDiemTB2 = new System.Windows.Forms.Label();
            this.txtDiemTB2 = new System.Windows.Forms.TextBox();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();

            this.grpDangKyBanDau = new System.Windows.Forms.GroupBox();
            this.lblHocPhanDK = new System.Windows.Forms.Label();
            this.cboHocPhanDK = new System.Windows.Forms.ComboBox();
            this.lblHocKyDK = new System.Windows.Forms.Label();
            this.txtHocKyDK = new System.Windows.Forms.TextBox();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.lstDangKyChoDuyet = new System.Windows.Forms.ListBox();
            this.btnXoaKhoiDS = new System.Windows.Forms.Button();

            this.chkGiaLapLoi = new System.Windows.Forms.CheckBox();
            this.btnLuuGiaoDich = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();

            this.tabMain.SuspendLayout();
            this.tabMasterDetail.SuspendLayout();
            this.grpKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.grpSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.grpDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.tabTransaction.SuspendLayout();
            this.grpSinhVienMoi.SuspendLayout();
            this.grpDangKyBanDau.SuspendLayout();
            this.SuspendLayout();
            //
            // tabMain
            //
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabMasterDetail);
            this.tabMain.Controls.Add(this.tabTransaction);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(976, 580);
            this.tabMain.TabIndex = 0;
            //
            // lblTrangThai
            //
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.lblTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrangThai.Location = new System.Drawing.Point(12, 602);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(976, 24);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Sẵn sàng";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // tabMasterDetail
            //
            this.tabMasterDetail.Controls.Add(this.grpKhoa);
            this.tabMasterDetail.Controls.Add(this.grpSinhVien);
            this.tabMasterDetail.Controls.Add(this.grpDangKy);
            this.tabMasterDetail.Location = new System.Drawing.Point(4, 22);
            this.tabMasterDetail.Name = "tabMasterDetail";
            this.tabMasterDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasterDetail.Size = new System.Drawing.Size(968, 554);
            this.tabMasterDetail.Text = "1-2. Master-Detail: Khoa > Sinh vien > Dang ky";
            this.tabMasterDetail.UseVisualStyleBackColor = true;
            //
            // grpKhoa
            //
            this.grpKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpKhoa.Controls.Add(this.dgvKhoa);
            this.grpKhoa.Location = new System.Drawing.Point(10, 10);
            this.grpKhoa.Name = "grpKhoa";
            this.grpKhoa.Size = new System.Drawing.Size(260, 530);
            this.grpKhoa.TabIndex = 0;
            this.grpKhoa.TabStop = false;
            this.grpKhoa.Text = "Khoa";
            //
            // dgvKhoa
            //
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.AutoGenerateColumns = false;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKhoaMa,
            this.colKhoaTen});
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoa.Location = new System.Drawing.Point(3, 16);
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersVisible = false;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(254, 511);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.SelectionChanged += new System.EventHandler(this.dgvKhoa_SelectionChanged);
            //
            this.colKhoaMa.DataPropertyName = "MaKhoa";
            this.colKhoaMa.HeaderText = "Mã khoa";
            this.colKhoaMa.Name = "colKhoaMa";
            this.colKhoaMa.ReadOnly = true;
            this.colKhoaMa.FillWeight = 35F;
            //
            this.colKhoaTen.DataPropertyName = "TenKhoa";
            this.colKhoaTen.HeaderText = "Tên khoa";
            this.colKhoaTen.Name = "colKhoaTen";
            this.colKhoaTen.ReadOnly = true;
            this.colKhoaTen.FillWeight = 65F;
            //
            // grpSinhVien
            //
            this.grpSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSinhVien.Controls.Add(this.dgvSinhVien);
            this.grpSinhVien.Location = new System.Drawing.Point(280, 10);
            this.grpSinhVien.Name = "grpSinhVien";
            this.grpSinhVien.Size = new System.Drawing.Size(678, 270);
            this.grpSinhVien.TabIndex = 1;
            this.grpSinhVien.TabStop = false;
            this.grpSinhVien.Text = "Sinh viên thuộc khoa đang chọn";
            //
            // dgvSinhVien
            //
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSvMa,
            this.colSvHoTen,
            this.colSvNgaySinh,
            this.colSvGioiTinh,
            this.colSvDiemTB,
            this.colSvEmail});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(672, 251);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            //
            this.colSvMa.DataPropertyName = "MaSV";
            this.colSvMa.HeaderText = "Mã SV";
            this.colSvMa.Name = "colSvMa";
            this.colSvMa.ReadOnly = true;
            this.colSvMa.FillWeight = 14F;
            //
            this.colSvHoTen.DataPropertyName = "HoTen";
            this.colSvHoTen.HeaderText = "Họ tên";
            this.colSvHoTen.Name = "colSvHoTen";
            this.colSvHoTen.ReadOnly = true;
            this.colSvHoTen.FillWeight = 26F;
            //
            this.colSvNgaySinh.DataPropertyName = "NgaySinh";
            this.colSvNgaySinh.HeaderText = "Ngày sinh";
            this.colSvNgaySinh.Name = "colSvNgaySinh";
            this.colSvNgaySinh.ReadOnly = true;
            this.colSvNgaySinh.FillWeight = 16F;
            //
            this.colSvGioiTinh.DataPropertyName = "GioiTinhText";
            this.colSvGioiTinh.HeaderText = "Giới tính";
            this.colSvGioiTinh.Name = "colSvGioiTinh";
            this.colSvGioiTinh.ReadOnly = true;
            this.colSvGioiTinh.FillWeight = 10F;
            //
            this.colSvDiemTB.DataPropertyName = "DiemTB";
            this.colSvDiemTB.HeaderText = "Điểm TB";
            this.colSvDiemTB.Name = "colSvDiemTB";
            this.colSvDiemTB.ReadOnly = true;
            this.colSvDiemTB.FillWeight = 12F;
            //
            this.colSvEmail.DataPropertyName = "Email";
            this.colSvEmail.HeaderText = "Email";
            this.colSvEmail.Name = "colSvEmail";
            this.colSvEmail.ReadOnly = true;
            this.colSvEmail.FillWeight = 22F;
            //
            // grpDangKy
            //
            this.grpDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDangKy.Controls.Add(this.dgvDangKy);
            this.grpDangKy.Controls.Add(this.lblHocPhanThem);
            this.grpDangKy.Controls.Add(this.cboHocPhanThem);
            this.grpDangKy.Controls.Add(this.lblHocKyThem);
            this.grpDangKy.Controls.Add(this.txtHocKyThem);
            this.grpDangKy.Controls.Add(this.btnThemDangKy);
            this.grpDangKy.Location = new System.Drawing.Point(280, 288);
            this.grpDangKy.Name = "grpDangKy";
            this.grpDangKy.Size = new System.Drawing.Size(678, 252);
            this.grpDangKy.TabIndex = 2;
            this.grpDangKy.TabStop = false;
            this.grpDangKy.Text = "Học phần đã đăng ký của sinh viên đang chọn";
            //
            // dgvDangKy
            //
            this.dgvDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDangKy.AllowUserToAddRows = false;
            this.dgvDangKy.AllowUserToDeleteRows = false;
            this.dgvDangKy.AutoGenerateColumns = false;
            this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDkMaHP,
            this.colDkTenHP,
            this.colDkSoTinChi,
            this.colDkHocKy,
            this.colDkDiem});
            this.dgvDangKy.Location = new System.Drawing.Point(10, 22);
            this.dgvDangKy.MultiSelect = false;
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.ReadOnly = true;
            this.dgvDangKy.RowHeadersVisible = false;
            this.dgvDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKy.Size = new System.Drawing.Size(658, 150);
            this.dgvDangKy.TabIndex = 0;
            //
            this.colDkMaHP.DataPropertyName = "MaHP";
            this.colDkMaHP.HeaderText = "Mã HP";
            this.colDkMaHP.Name = "colDkMaHP";
            this.colDkMaHP.ReadOnly = true;
            this.colDkMaHP.FillWeight = 14F;
            //
            this.colDkTenHP.DataPropertyName = "TenHP";
            this.colDkTenHP.HeaderText = "Tên học phần";
            this.colDkTenHP.Name = "colDkTenHP";
            this.colDkTenHP.ReadOnly = true;
            this.colDkTenHP.FillWeight = 34F;
            //
            this.colDkSoTinChi.DataPropertyName = "SoTinChi";
            this.colDkSoTinChi.HeaderText = "Số TC";
            this.colDkSoTinChi.Name = "colDkSoTinChi";
            this.colDkSoTinChi.ReadOnly = true;
            this.colDkSoTinChi.FillWeight = 12F;
            //
            this.colDkHocKy.DataPropertyName = "HocKy";
            this.colDkHocKy.HeaderText = "Học kỳ";
            this.colDkHocKy.Name = "colDkHocKy";
            this.colDkHocKy.ReadOnly = true;
            this.colDkHocKy.FillWeight = 12F;
            //
            this.colDkDiem.DataPropertyName = "Diem";
            this.colDkDiem.HeaderText = "Điểm";
            this.colDkDiem.Name = "colDkDiem";
            this.colDkDiem.ReadOnly = true;
            this.colDkDiem.FillWeight = 12F;
            //
            this.lblHocPhanThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHocPhanThem.AutoSize = true;
            this.lblHocPhanThem.Location = new System.Drawing.Point(10, 183);
            this.lblHocPhanThem.Text = "Thêm đăng ký - Học phần:";
            //
            this.cboHocPhanThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboHocPhanThem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocPhanThem.FormattingEnabled = true;
            this.cboHocPhanThem.Location = new System.Drawing.Point(180, 180);
            this.cboHocPhanThem.Name = "cboHocPhanThem";
            this.cboHocPhanThem.Size = new System.Drawing.Size(260, 21);
            //
            this.lblHocKyThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHocKyThem.AutoSize = true;
            this.lblHocKyThem.Location = new System.Drawing.Point(450, 183);
            this.lblHocKyThem.Text = "Học kỳ:";
            //
            this.txtHocKyThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHocKyThem.Location = new System.Drawing.Point(500, 180);
            this.txtHocKyThem.Name = "txtHocKyThem";
            this.txtHocKyThem.Size = new System.Drawing.Size(40, 20);
            this.txtHocKyThem.Text = "1";
            //
            this.btnThemDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemDangKy.Location = new System.Drawing.Point(550, 178);
            this.btnThemDangKy.Name = "btnThemDangKy";
            this.btnThemDangKy.Size = new System.Drawing.Size(118, 26);
            this.btnThemDangKy.Text = "Thêm đăng ký";
            this.btnThemDangKy.UseVisualStyleBackColor = true;
            this.btnThemDangKy.Click += new System.EventHandler(this.btnThemDangKy_Click);
            //
            // tabTransaction
            //
            this.tabTransaction.Controls.Add(this.grpSinhVienMoi);
            this.tabTransaction.Controls.Add(this.grpDangKyBanDau);
            this.tabTransaction.Controls.Add(this.chkGiaLapLoi);
            this.tabTransaction.Controls.Add(this.btnLuuGiaoDich);
            this.tabTransaction.Controls.Add(this.btnKiemTra);
            this.tabTransaction.Controls.Add(this.lblKetQua);
            this.tabTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransaction.Size = new System.Drawing.Size(968, 554);
            this.tabTransaction.Text = "3-5. Transaction: Them SV kem dang ky";
            this.tabTransaction.UseVisualStyleBackColor = true;
            //
            // grpSinhVienMoi
            //
            this.grpSinhVienMoi.Controls.Add(this.lblMaSV2);
            this.grpSinhVienMoi.Controls.Add(this.txtMaSV2);
            this.grpSinhVienMoi.Controls.Add(this.lblHoTen2);
            this.grpSinhVienMoi.Controls.Add(this.txtHoTen2);
            this.grpSinhVienMoi.Controls.Add(this.lblNgaySinh2);
            this.grpSinhVienMoi.Controls.Add(this.dtpNgaySinh2);
            this.grpSinhVienMoi.Controls.Add(this.radNam2);
            this.grpSinhVienMoi.Controls.Add(this.radNu2);
            this.grpSinhVienMoi.Controls.Add(this.lblKhoa2);
            this.grpSinhVienMoi.Controls.Add(this.cboKhoa2);
            this.grpSinhVienMoi.Controls.Add(this.lblDiemTB2);
            this.grpSinhVienMoi.Controls.Add(this.txtDiemTB2);
            this.grpSinhVienMoi.Controls.Add(this.lblEmail2);
            this.grpSinhVienMoi.Controls.Add(this.txtEmail2);
            this.grpSinhVienMoi.Location = new System.Drawing.Point(10, 10);
            this.grpSinhVienMoi.Name = "grpSinhVienMoi";
            this.grpSinhVienMoi.Size = new System.Drawing.Size(460, 240);
            this.grpSinhVienMoi.TabIndex = 0;
            this.grpSinhVienMoi.TabStop = false;
            this.grpSinhVienMoi.Text = "Sinh viên mới";
            //
            this.lblMaSV2.AutoSize = true;
            this.lblMaSV2.Location = new System.Drawing.Point(15, 28);
            this.lblMaSV2.Text = "Mã SV:";
            //
            this.txtMaSV2.Location = new System.Drawing.Point(120, 25);
            this.txtMaSV2.Name = "txtMaSV2";
            this.txtMaSV2.Size = new System.Drawing.Size(320, 20);
            //
            this.lblHoTen2.AutoSize = true;
            this.lblHoTen2.Location = new System.Drawing.Point(15, 58);
            this.lblHoTen2.Text = "Họ tên:";
            //
            this.txtHoTen2.Location = new System.Drawing.Point(120, 55);
            this.txtHoTen2.Name = "txtHoTen2";
            this.txtHoTen2.Size = new System.Drawing.Size(320, 20);
            //
            this.lblNgaySinh2.AutoSize = true;
            this.lblNgaySinh2.Location = new System.Drawing.Point(15, 88);
            this.lblNgaySinh2.Text = "Ngày sinh:";
            //
            this.dtpNgaySinh2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh2.Location = new System.Drawing.Point(120, 85);
            this.dtpNgaySinh2.Name = "dtpNgaySinh2";
            this.dtpNgaySinh2.Size = new System.Drawing.Size(150, 20);
            //
            this.radNam2.AutoSize = true;
            this.radNam2.Checked = true;
            this.radNam2.TabStop = true;
            this.radNam2.Location = new System.Drawing.Point(15, 118);
            this.radNam2.Text = "Nam";
            //
            this.radNu2.AutoSize = true;
            this.radNu2.Location = new System.Drawing.Point(90, 118);
            this.radNu2.Text = "Nữ";
            //
            this.lblKhoa2.AutoSize = true;
            this.lblKhoa2.Location = new System.Drawing.Point(15, 148);
            this.lblKhoa2.Text = "Khoa:";
            //
            this.cboKhoa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa2.FormattingEnabled = true;
            this.cboKhoa2.Location = new System.Drawing.Point(120, 145);
            this.cboKhoa2.Name = "cboKhoa2";
            this.cboKhoa2.Size = new System.Drawing.Size(320, 21);
            //
            this.lblDiemTB2.AutoSize = true;
            this.lblDiemTB2.Location = new System.Drawing.Point(15, 178);
            this.lblDiemTB2.Text = "Điểm TB:";
            //
            this.txtDiemTB2.Location = new System.Drawing.Point(120, 175);
            this.txtDiemTB2.Name = "txtDiemTB2";
            this.txtDiemTB2.Size = new System.Drawing.Size(80, 20);
            //
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(15, 208);
            this.lblEmail2.Text = "Email:";
            //
            this.txtEmail2.Location = new System.Drawing.Point(120, 205);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(320, 20);
            //
            // grpDangKyBanDau
            //
            this.grpDangKyBanDau.Controls.Add(this.lblHocPhanDK);
            this.grpDangKyBanDau.Controls.Add(this.cboHocPhanDK);
            this.grpDangKyBanDau.Controls.Add(this.lblHocKyDK);
            this.grpDangKyBanDau.Controls.Add(this.txtHocKyDK);
            this.grpDangKyBanDau.Controls.Add(this.btnThemVaoDS);
            this.grpDangKyBanDau.Controls.Add(this.lstDangKyChoDuyet);
            this.grpDangKyBanDau.Controls.Add(this.btnXoaKhoiDS);
            this.grpDangKyBanDau.Location = new System.Drawing.Point(480, 10);
            this.grpDangKyBanDau.Name = "grpDangKyBanDau";
            this.grpDangKyBanDau.Size = new System.Drawing.Size(478, 240);
            this.grpDangKyBanDau.TabIndex = 1;
            this.grpDangKyBanDau.TabStop = false;
            this.grpDangKyBanDau.Text = "Danh sách đăng ký ban đầu (chưa lưu)";
            //
            this.lblHocPhanDK.AutoSize = true;
            this.lblHocPhanDK.Location = new System.Drawing.Point(15, 28);
            this.lblHocPhanDK.Text = "Học phần:";
            //
            this.cboHocPhanDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocPhanDK.FormattingEnabled = true;
            this.cboHocPhanDK.Location = new System.Drawing.Point(90, 25);
            this.cboHocPhanDK.Name = "cboHocPhanDK";
            this.cboHocPhanDK.Size = new System.Drawing.Size(210, 21);
            //
            this.lblHocKyDK.AutoSize = true;
            this.lblHocKyDK.Location = new System.Drawing.Point(310, 28);
            this.lblHocKyDK.Text = "HK:";
            //
            this.txtHocKyDK.Location = new System.Drawing.Point(345, 25);
            this.txtHocKyDK.Name = "txtHocKyDK";
            this.txtHocKyDK.Size = new System.Drawing.Size(40, 20);
            this.txtHocKyDK.Text = "1";
            //
            this.btnThemVaoDS.Location = new System.Drawing.Point(390, 23);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(75, 25);
            this.btnThemVaoDS.Text = "Thêm";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            //
            this.lstDangKyChoDuyet.FormattingEnabled = true;
            this.lstDangKyChoDuyet.Location = new System.Drawing.Point(15, 58);
            this.lstDangKyChoDuyet.Name = "lstDangKyChoDuyet";
            this.lstDangKyChoDuyet.Size = new System.Drawing.Size(450, 134);
            this.lstDangKyChoDuyet.TabIndex = 4;
            //
            this.btnXoaKhoiDS.Location = new System.Drawing.Point(15, 200);
            this.btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            this.btnXoaKhoiDS.Size = new System.Drawing.Size(160, 26);
            this.btnXoaKhoiDS.Text = "Xóa dòng đã chọn";
            this.btnXoaKhoiDS.UseVisualStyleBackColor = true;
            this.btnXoaKhoiDS.Click += new System.EventHandler(this.btnXoaKhoiDS_Click);
            //
            this.chkGiaLapLoi.AutoSize = true;
            this.chkGiaLapLoi.Location = new System.Drawing.Point(15, 265);
            this.chkGiaLapLoi.Name = "chkGiaLapLoi";
            this.chkGiaLapLoi.Text = "Giả lập lỗi (bài 4): thêm 1 mã học phần không tồn tại để kiểm chứng Rollback";
            this.chkGiaLapLoi.AutoSize = true;
            this.chkGiaLapLoi.UseVisualStyleBackColor = true;
            //
            this.btnLuuGiaoDich.Location = new System.Drawing.Point(15, 300);
            this.btnLuuGiaoDich.Name = "btnLuuGiaoDich";
            this.btnLuuGiaoDich.Size = new System.Drawing.Size(220, 34);
            this.btnLuuGiaoDich.Text = "Lưu (Transaction)";
            this.btnLuuGiaoDich.UseVisualStyleBackColor = true;
            this.btnLuuGiaoDich.Click += new System.EventHandler(this.btnLuuGiaoDich_Click);
            //
            this.btnKiemTra.Location = new System.Drawing.Point(245, 300);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(230, 34);
            this.btnKiemTra.Text = "Kiểm tra SV đã được lưu chưa";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            //
            this.lblKetQua.Location = new System.Drawing.Point(15, 345);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(940, 100);
            this.lblKetQua.Text = "Chưa thực hiện thao tác nào.";
            //
            // frmMasterDetail
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblTrangThai);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "frmMasterDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 12 - Master-Detail, Transaction va hoan thien mo hinh 3 lop";
            this.Load += new System.EventHandler(this.frmMasterDetail_Load);
            this.tabMain.ResumeLayout(false);
            this.tabMasterDetail.ResumeLayout(false);
            this.grpKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.grpSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.grpDangKy.ResumeLayout(false);
            this.grpDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.tabTransaction.ResumeLayout(false);
            this.grpSinhVienMoi.ResumeLayout(false);
            this.grpSinhVienMoi.PerformLayout();
            this.grpDangKyBanDau.ResumeLayout(false);
            this.grpDangKyBanDau.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Label lblTrangThai;

        private System.Windows.Forms.TabPage tabMasterDetail;
        private System.Windows.Forms.GroupBox grpKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaTen;

        private System.Windows.Forms.GroupBox grpSinhVien;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSvEmail;

        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDkMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDkTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDkSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDkHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDkDiem;
        private System.Windows.Forms.Label lblHocPhanThem;
        private System.Windows.Forms.ComboBox cboHocPhanThem;
        private System.Windows.Forms.Label lblHocKyThem;
        private System.Windows.Forms.TextBox txtHocKyThem;
        private System.Windows.Forms.Button btnThemDangKy;

        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.GroupBox grpSinhVienMoi;
        private System.Windows.Forms.Label lblMaSV2;
        private System.Windows.Forms.TextBox txtMaSV2;
        private System.Windows.Forms.Label lblHoTen2;
        private System.Windows.Forms.TextBox txtHoTen2;
        private System.Windows.Forms.Label lblNgaySinh2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh2;
        private System.Windows.Forms.RadioButton radNam2;
        private System.Windows.Forms.RadioButton radNu2;
        private System.Windows.Forms.Label lblKhoa2;
        private System.Windows.Forms.ComboBox cboKhoa2;
        private System.Windows.Forms.Label lblDiemTB2;
        private System.Windows.Forms.TextBox txtDiemTB2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.TextBox txtEmail2;

        private System.Windows.Forms.GroupBox grpDangKyBanDau;
        private System.Windows.Forms.Label lblHocPhanDK;
        private System.Windows.Forms.ComboBox cboHocPhanDK;
        private System.Windows.Forms.Label lblHocKyDK;
        private System.Windows.Forms.TextBox txtHocKyDK;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.ListBox lstDangKyChoDuyet;
        private System.Windows.Forms.Button btnXoaKhoiDS;

        private System.Windows.Forms.CheckBox chkGiaLapLoi;
        private System.Windows.Forms.Button btnLuuGiaoDich;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblKetQua;
    }
}
