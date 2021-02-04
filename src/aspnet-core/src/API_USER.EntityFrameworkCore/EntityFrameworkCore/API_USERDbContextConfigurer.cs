using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace API_USER.EntityFrameworkCore
{
    public static class API_USERDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<API_USERDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<API_USERDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
