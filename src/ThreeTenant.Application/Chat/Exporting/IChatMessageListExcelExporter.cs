using System.Collections.Generic;
using Abp;
using ThreeTenant.Chat.Dto;
using ThreeTenant.Dto;

namespace ThreeTenant.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
