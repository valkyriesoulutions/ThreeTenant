using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using ThreeTenant.Authorization.Users;
using ThreeTenant.MultiTenancy;

namespace ThreeTenant.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}