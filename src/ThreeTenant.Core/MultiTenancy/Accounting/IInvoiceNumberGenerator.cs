﻿using System.Threading.Tasks;
using Abp.Dependency;

namespace ThreeTenant.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}