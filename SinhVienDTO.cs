using System;

namespace Lab12.DTO
{
    public class SinhVienDTO
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaKhoa { get; set; }
        public decimal DiemTB { get; set; }
        public string Email { get; set; }
        public string TenKhoa { get; set; }

        public string GioiTinhText
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }
    }
}
