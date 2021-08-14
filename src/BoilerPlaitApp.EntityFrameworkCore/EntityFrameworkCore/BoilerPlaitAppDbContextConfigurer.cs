using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlaitApp.EntityFrameworkCore
{
    public static class BoilerPlaitAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BoilerPlaitAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BoilerPlaitAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
