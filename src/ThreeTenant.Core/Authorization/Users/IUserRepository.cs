﻿using System;
using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace ThreeTenant.Authorization.Users
{
    public interface IUserRepository : IRepository<User, long>
    {
        List<long> GetPasswordExpiredUserIds(DateTime passwordExpireDate);
        
        void UpdateUsersToChangePasswordOnNextLogin(List<long> userIdsToUpdate);
    }
}
