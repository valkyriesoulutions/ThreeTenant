using System.Collections.Generic;
using ThreeTenant.Authorization.Permissions.Dto;

namespace ThreeTenant.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}