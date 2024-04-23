using Microsoft.AspNetCore.Identity;

namespace Servisto.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
