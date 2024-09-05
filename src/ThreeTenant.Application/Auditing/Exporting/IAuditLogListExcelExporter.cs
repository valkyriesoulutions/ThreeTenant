using System.Collections.Generic;
using ThreeTenant.Auditing.Dto;
using ThreeTenant.Dto;

namespace ThreeTenant.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
