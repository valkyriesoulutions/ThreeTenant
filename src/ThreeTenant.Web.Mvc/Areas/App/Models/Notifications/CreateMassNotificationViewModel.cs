﻿using System.Collections.Generic;
using Abp.Notifications;

namespace ThreeTenant.Web.Areas.App.Models.Notifications
{
    public class CreateMassNotificationViewModel
    {
        public List<string> TargetNotifiers { get; set; }
    
        public NotificationSeverity Severity { get; set; }
    }
}