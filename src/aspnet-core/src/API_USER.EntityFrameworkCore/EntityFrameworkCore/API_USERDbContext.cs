using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using API_USER.Authorization.Roles;
using API_USER.Authorization.Users;
using API_USER.MultiTenancy;
using API_USER.Core;

namespace API_USER.EntityFrameworkCore
{
    public class API_USERDbContext : AbpZeroDbContext<Tenant, Role, User, API_USERDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Pessoa> Pessoas { get; set; }

        public API_USERDbContext(DbContextOptions<API_USERDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>(new PessoaMap().Configure);
        }
    }
}
