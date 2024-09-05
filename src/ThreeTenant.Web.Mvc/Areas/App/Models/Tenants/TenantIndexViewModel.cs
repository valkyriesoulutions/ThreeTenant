using System.Collections.Generic;
using ThreeTenant.Editions.Dto;

namespace ThreeTenant.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}