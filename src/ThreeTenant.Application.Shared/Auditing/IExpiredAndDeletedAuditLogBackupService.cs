﻿using System.Collections.Generic;
using Abp.Auditing;

namespace ThreeTenant.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}