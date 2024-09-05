using System.Collections.Generic;
using ThreeTenant.Authorization.Users.Importing.Dto;
using ThreeTenant.Dto;

namespace ThreeTenant.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
