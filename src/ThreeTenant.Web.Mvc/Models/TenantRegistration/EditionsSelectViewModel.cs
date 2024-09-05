using Abp.AutoMapper;
using ThreeTenant.MultiTenancy.Dto;

namespace ThreeTenant.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
