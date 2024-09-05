using Abp.AutoMapper;
using ThreeTenant.MultiTenancy;
using ThreeTenant.MultiTenancy.Dto;
using ThreeTenant.Web.Areas.App.Models.Common;

namespace ThreeTenant.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}