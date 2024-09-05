using Abp.AutoMapper;
using ThreeTenant.Authorization.Users;
using ThreeTenant.Authorization.Users.Dto;
using ThreeTenant.Web.Areas.App.Models.Common;

namespace ThreeTenant.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}