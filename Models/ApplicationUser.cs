using Microsoft.AspNetCore.Identity;

namespace POETWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string AccountCode { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
