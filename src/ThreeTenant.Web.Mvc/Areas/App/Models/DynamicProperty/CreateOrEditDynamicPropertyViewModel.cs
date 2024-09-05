﻿using System.Collections.Generic;
using ThreeTenant.DynamicEntityProperties.Dto;

namespace ThreeTenant.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
