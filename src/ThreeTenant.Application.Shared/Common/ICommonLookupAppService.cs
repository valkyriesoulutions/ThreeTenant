using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThreeTenant.Common.Dto;
using ThreeTenant.Editions.Dto;

namespace ThreeTenant.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}