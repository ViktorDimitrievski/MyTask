using Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace Repositories
{
    public class Database : IdentityDbContext<ApplicationUser>
    {
        public Database()
            : base("DefaultConnection" , throwIfV1Schema: false)
        {
        }
        public DbSet<Project> Project { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Customer> Customer { get; set; }


        public static Database Create()
        {
            return new Database();
        }

        //public System.Data.Entity.DbSet<Entities.ApplicationUser> ApplicationUsers { get; set; }
    }
}
