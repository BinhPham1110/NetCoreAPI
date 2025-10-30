using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        [Required]
        public string MaHTPP { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenHTPP { get; set; } = string.Empty;

        [StringLength(200)]
        public string? DiaChi { get; set; }

        [Phone]
        [StringLength(20)]
        public string? DienThoai { get; set; }

        // Navigation: 1 HTPP có nhiều Đại lý
        public ICollection<DaiLy>? DaiLys { get; set; }
    }
}
