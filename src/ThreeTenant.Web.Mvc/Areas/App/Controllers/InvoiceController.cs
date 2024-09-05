using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using ThreeTenant.MultiTenancy.Accounting;
using ThreeTenant.Web.Areas.App.Models.Accounting;
using ThreeTenant.Web.Controllers;

namespace ThreeTenant.Web.Areas.App.Controllers
{
    [Area("App")]
    public class InvoiceController : ThreeTenantControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}