﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ThreeTenant.Editions.Dto;
using ThreeTenant.MultiTenancy.Dto;

namespace ThreeTenant.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}