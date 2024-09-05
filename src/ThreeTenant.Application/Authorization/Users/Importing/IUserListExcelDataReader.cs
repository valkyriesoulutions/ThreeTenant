using System.Collections.Generic;
using ThreeTenant.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace ThreeTenant.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
