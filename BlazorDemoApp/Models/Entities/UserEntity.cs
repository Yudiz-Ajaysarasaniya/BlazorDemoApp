using BlazorDemoApp.Models.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Models.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Otp { get; set; }
        public DateTime? OtpExpireTime { get; set; }
    }
}
