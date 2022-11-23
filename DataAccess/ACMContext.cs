using System;
using System.Data.Entity;
using Module;
namespace DataAccess
{
    public class ACMContext: DbContext
    {
        public ACMContext() : base()
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<TenantUser> TenantUsers { get; set; }
    }
}
