using Microsoft.AspNetCore.Identity;

namespace NexEventMVC2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }

        public required string RoleName { get; set; }

        public string? PhoneNumberCustom { get; set; }
    }
}