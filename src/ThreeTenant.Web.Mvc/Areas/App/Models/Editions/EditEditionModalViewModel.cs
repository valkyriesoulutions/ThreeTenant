using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ThreeTenant.Editions.Dto;
using ThreeTenant.Web.Areas.App.Models.Common;

namespace ThreeTenant.Web.Areas.App.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}