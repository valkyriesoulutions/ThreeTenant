﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ThreeTenant.Authorization.Permissions.Dto;
using ThreeTenant.Web.Areas.App.Models.Common;

namespace ThreeTenant.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}