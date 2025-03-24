using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Models.Request
{
    public class UserPersistRequest
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
