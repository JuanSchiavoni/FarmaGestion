using FarmaGestion.Data;
using Microsoft.AspNetCore.Identity;

namespace FarmaGestion.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FarmaGestionUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FarmaGestionUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
