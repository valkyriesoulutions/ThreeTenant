using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ThreeTenant.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly ThreeTenantAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new ThreeTenantAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
