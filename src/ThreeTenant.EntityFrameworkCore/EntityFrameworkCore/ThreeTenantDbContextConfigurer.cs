using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThreeTenant.EntityFrameworkCore
{
    public static class ThreeTenantDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ThreeTenantDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ThreeTenantDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}