using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ThreeTenant.MultiTenancy.Accounting.Dto;

namespace ThreeTenant.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
