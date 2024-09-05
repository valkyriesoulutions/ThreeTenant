﻿using Microsoft.AspNetCore.Antiforgery;

namespace ThreeTenant.Web.Controllers
{
    public class AntiForgeryController : ThreeTenantControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
