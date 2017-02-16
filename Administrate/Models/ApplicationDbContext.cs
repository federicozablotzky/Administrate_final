using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Administrate.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<BuildingModel> Buildings { get; set; }
        public DbSet<DepartamentoModel> Departament { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }



}