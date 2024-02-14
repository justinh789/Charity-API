using CharityApp.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Data.UnitOfWork
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {

        }

        public DbSet<Organization> Charity { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
                .ToTable("organizations", "charity")
                .HasKey(charity => charity.Id);

            //Property renaming...
         /*   modelBuilder.Entity<Organization>()
                .Property(charityProp => charityProp.Email).HasColumnName("E-mail");
            modelBuilder.Entity<Organization>()
                .Property(charityProp => charityProp.Type_of_Deregistration).HasColumnName("Type_of_De-registration");*/

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
