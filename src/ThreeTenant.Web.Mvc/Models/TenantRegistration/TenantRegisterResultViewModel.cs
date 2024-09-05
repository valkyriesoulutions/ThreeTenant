using Abp.AutoMapper;
using ThreeTenant.MultiTenancy.Dto;

namespace ThreeTenant.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}