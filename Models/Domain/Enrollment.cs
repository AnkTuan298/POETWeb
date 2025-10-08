using System.ComponentModel.DataAnnotations;

namespace POETWeb.Models.Domain
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        // "Student" mặc định
        [StringLength(30)]
        public string RoleInClass { get; set; } = "Student";

        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    }
}
