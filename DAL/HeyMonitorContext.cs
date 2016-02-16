using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{


    public class HeyMonitorContext : IdentityDbContext<ApplicationUser, CustomIdentityRole, long, CustomIdentityUserLogin, CustomIdentityUserRole, CustomIdentityUserClaim>
    {
        public HeyMonitorContext() : base("HeyMonitorContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HeyMonitorContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
