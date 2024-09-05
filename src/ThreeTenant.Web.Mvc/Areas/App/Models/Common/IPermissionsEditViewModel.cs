using System.Collections.Generic;
using ThreeTenant.Authorization.Permissions.Dto;

namespace ThreeTenant.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}