using System.Collections.Generic;
using ThreeTenant.Authorization.Users.Dto;
using ThreeTenant.Dto;

namespace ThreeTenant.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}