using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using ThreeTenant.Dto;

namespace ThreeTenant.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
