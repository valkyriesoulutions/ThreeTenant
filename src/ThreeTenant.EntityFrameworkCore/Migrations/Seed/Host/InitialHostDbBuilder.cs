using ThreeTenant.EntityFrameworkCore;

namespace ThreeTenant.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ThreeTenantDbContext _context;

        public InitialHostDbBuilder(ThreeTenantDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
