using System.Collections.Generic;

namespace ThreeTenant.Authorization.Users.Profile.Dto
{
    public class UpdateGoogleAuthenticatorKeyOutput
    {
        public IEnumerable<string> RecoveryCodes { get; set; }
    }
}
