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

        public DbSet<Charity> Charity { get; set; }
     

        //This now becomes one MASSIVE method... ???
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Charity>()
                .ToTable("Charities", "dbo")
                .HasKey(charity => charity.Id);

            //Property renaming...
            modelBuilder.Entity<Charity>()
                .Property(charityProp => charityProp.Email).HasColumnName("E-mail");
            modelBuilder.Entity<Charity>()
                .Property(charityProp => charityProp.Type_of_Deregistration).HasColumnName("Type_of_De-registration");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
