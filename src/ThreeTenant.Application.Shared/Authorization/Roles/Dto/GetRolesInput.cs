﻿using System.Collections.Generic;

namespace ThreeTenant.Authorization.Roles.Dto
{
    public class GetRolesInput
    {
        public List<string> Permissions { get; set; }
    }
}
