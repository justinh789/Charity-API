using CharityApp.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CharityApp.Core.Domain;

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

            modelBuilder.Entity<Organization>().Property(org => org.Active).HasColumnName("active");
            modelBuilder.Entity<Organization>().Property(org => org.CreatedOnUtc).HasColumnName("created_on_utc");
            modelBuilder.Entity<Organization>().Property(org => org.DateRegistered).HasColumnName("date_registered");
            modelBuilder.Entity<Organization>().Property(org => org.Description).HasColumnName("description");
            modelBuilder.Entity<Organization>().Property(org => org.DueDate).HasColumnName("due_date");
            modelBuilder.Entity<Organization>().Property(org => org.FinancialYearEnd).HasColumnName("financial_year_end");
            modelBuilder.Entity<Organization>().Property(org => org.Id).HasColumnName("id");
            modelBuilder.Entity<Organization>().Property(org => org.NpoName).HasColumnName("npo_name");
            modelBuilder.Entity<Organization>().Property(org => org.NpoRegNumber).HasColumnName("npo_reg_number");
            modelBuilder.Entity<Organization>().Property(org => org.Objective).HasColumnName("objective");
            modelBuilder.Entity<Organization>().Property(org => org.RegistrationStatus).HasColumnName("registration_status");
            modelBuilder.Entity<Organization>().Property(org => org.CreatedOnUtc).HasColumnName("created_on_utc");
            modelBuilder.Entity<Organization>().Property(org => org.Sector).HasColumnName("sector");
            modelBuilder.Entity<Organization>().Property(org => org.Theme).HasColumnName("theme");
            modelBuilder.Entity<Organization>().Property(org => org.TypeofDeregistration).HasColumnName("type_of_deregistration");
            modelBuilder.Entity<Organization>().Property(org => org.UpdatedOnUtc).HasColumnName("updated_on_utc");
            modelBuilder.Entity<Organization>().Property(org => org.TypeOfOrganization).HasColumnName("type_of_organization");

            modelBuilder.Entity<Category>().ToTable("categories", "charity").HasKey(cat => cat.Id);
            modelBuilder.Entity<Category>()
                .HasMany(cat => cat.Subcategories)
                .WithOne(sub => sub.Category)
                .HasForeignKey(sub => sub.CategoryId)
                .IsRequired();
            modelBuilder.Entity<Category>().Property(cat => cat.Id).HasColumnName("id");
            modelBuilder.Entity<Category>().Property(cat => cat.Description).HasColumnName("description");
            modelBuilder.Entity<Category>().Property(cat => cat.Name).HasColumnName("name");

            modelBuilder.Entity<Subcategory>().ToTable("subcategories", "charity").HasKey(sub => sub.Id);
            modelBuilder.Entity<Subcategory>().Property(sub => sub.CategoryId).HasColumnName("category_id");
            modelBuilder.Entity<Subcategory>().Property(sub => sub.Id).HasColumnName("id");
            modelBuilder.Entity<Subcategory>().Property(sub => sub.Description).HasColumnName("description");
            modelBuilder.Entity<Subcategory>().Property(sub => sub.Name).HasColumnName("name");




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
