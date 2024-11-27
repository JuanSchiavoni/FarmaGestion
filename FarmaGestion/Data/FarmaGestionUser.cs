using FarmaGestion.Model;
using Microsoft.AspNetCore.Identity;

namespace FarmaGestion.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FarmaGestionUser : IdentityUser
    {
        public Cliente? Cliente { get; set; }
    }
    
}
