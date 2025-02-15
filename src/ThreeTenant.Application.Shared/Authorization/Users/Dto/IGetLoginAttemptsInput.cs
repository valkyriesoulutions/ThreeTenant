﻿using Abp.Application.Services.Dto;

namespace ThreeTenant.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}