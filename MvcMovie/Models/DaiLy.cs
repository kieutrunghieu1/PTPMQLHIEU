namespace MvcMovie.Models
{
    public class DaiLy
    {
        public string?MaDaiLy { get; set; }
        public string?TenDaiLy { get; set; }
        public string?DiaChi { get; set; }
        public string?NguoiDaiDien { get; set; }
        public string?DienThoai { get; set; }

        // Liên kết với HeThongPhanPhoi
        public string?MaHTPP { get; set; }
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; } // Quan hệ 1-n với HeThongPhanPhoi
    }
}
