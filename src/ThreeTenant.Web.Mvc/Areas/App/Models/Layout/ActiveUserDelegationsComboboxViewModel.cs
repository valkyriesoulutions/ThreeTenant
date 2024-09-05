using System.Collections.Generic;
using ThreeTenant.Authorization.Delegation;
using ThreeTenant.Authorization.Users.Delegation.Dto;

namespace ThreeTenant.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
