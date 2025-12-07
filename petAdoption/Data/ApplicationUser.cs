using Microsoft.AspNetCore.Identity;

namespace petAdoption.Data
{
    // Extends the base IdentityUser to add custom profile data
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}