using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace Scania.Objects
{
    public static class Utils
    {
        public static void AddNormalized(this IdentityUser identityUser)
        {
            Debug.Assert(identityUser != null);

            identityUser.NormalizedEmail = identityUser.Email.ToUpper();
            identityUser.NormalizedUserName = identityUser.UserName.ToUpper();
        }
    }
}