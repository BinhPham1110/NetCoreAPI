using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    public class DaiLy
    {
        [Key]
        [Required]
        public string MaDaiLy { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenDaiLy { get; set; } = string.Empty;

        [StringLength(200)]
        public string? DiaChi { get; set; }

        [StringLength(100)]
        public string? NguoiDaiDien { get; set; }

        [Phone]
        [StringLength(20)]
        public string? DienThoai { get; set; }

        // Khóa ngoại liên kết với HeThongPhanPhoi
        [Required]
        public string MaHTPP { get; set; } = string.Empty;

        [ForeignKey("MaHTPP")]
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
    }
}