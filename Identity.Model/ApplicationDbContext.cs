using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Model
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser, ApplicationRole, string,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Controles");

            modelBuilder.Entity<ApplicationUser>(b =>
            {
                // Primary key
                b.HasKey(u => u.Id);

               
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                // Primary key
                b.HasKey(u => u.Id);

            });

            modelBuilder.Entity<ApplicationUserRole>(b =>
            {
                //Primary key
                b.HasKey(r => new { r.UserId, r.RoleId });
            });

            modelBuilder.Entity<ApplicationRoleClaim>(b =>
            {
                //Primary key
                b.HasKey(rc => rc.Id);
            });

            modelBuilder.Entity<ApplicationUserClaim>(b =>
            {
                // Primary key
                b.HasKey(uc => uc.Id);
            });

            modelBuilder.Entity<ApplicationUserToken>(b =>
            {
                // Composite primary key consisting of the UserId, LoginProvider and Name
                b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            });

            modelBuilder.Entity<ApplicationUserLogin>(b =>
            {
                // Composite primary key consisting of the UserId, LoginProvider and Name
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });

        }
    }
}
