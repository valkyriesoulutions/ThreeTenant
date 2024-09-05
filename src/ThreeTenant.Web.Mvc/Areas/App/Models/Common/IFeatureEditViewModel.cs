using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ThreeTenant.Editions.Dto;

namespace ThreeTenant.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}