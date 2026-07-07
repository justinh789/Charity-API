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
                .ToTable("tOrganizations", "charity")
                .HasKey(charity => charity.Id);

            modelBuilder.Entity<Organization>().Property(org => org.Id).HasColumnName("OrganizationId").ValueGeneratedOnAdd();
            modelBuilder.Entity<Organization>().Property(org => org.NpoName).HasColumnName("NpoName").HasColumnType("nvarchar(4000)");
            modelBuilder.Entity<Organization>().Property(org => org.NpoRegNumber).HasColumnName("NpoRegNumber").HasColumnType("varchar(20)");
            modelBuilder.Entity<Organization>().Property(org => org.TypeOfOrganization).HasColumnName("TypeOfOrganization").HasColumnType("varchar(50)");
            modelBuilder.Entity<Organization>().Property(org => org.RegistrationStatus).HasColumnName("RegistrationStatus").HasColumnType("varchar(20)");
            modelBuilder.Entity<Organization>().Property(org => org.DateRegistered).HasColumnName("DateRegistered").HasColumnType("date");
            modelBuilder.Entity<Organization>().Property(org => org.Sector).HasColumnName("Sector").HasColumnType("varchar(100)");
            modelBuilder.Entity<Organization>().Property(org => org.Objective).HasColumnName("Objective").HasColumnType("varchar(100)");
            modelBuilder.Entity<Organization>().Property(org => org.Theme).HasColumnName("Theme").HasColumnType("varchar(50)");
            modelBuilder.Entity<Organization>().Property(org => org.Description).HasColumnName("Description").HasColumnType("varchar(255)");
            modelBuilder.Entity<Organization>().Property(org => org.TypeofDeregistration).HasColumnName("TypeOfDeregistration").HasColumnType("varchar(50)");
            modelBuilder.Entity<Organization>().Property(org => org.FinancialYearEnd).HasColumnName("FinancialYearEnd").HasColumnType("varchar(12)");
            modelBuilder.Entity<Organization>().Property(org => org.DueDate).HasColumnName("DueDate").HasColumnType("date");
            modelBuilder.Entity<Organization>().Property(org => org.Active).HasColumnName("Active").HasColumnType("bit");
            modelBuilder.Entity<Organization>().Property(org => org.CreatedOnUtc).HasColumnName("CreatedOnUtc").HasColumnType("datetime2(7)");
            modelBuilder.Entity<Organization>().Property(org => org.UpdatedOnUtc).HasColumnName("UpdatedOnUtc").HasColumnType("datetime2(7)");
            modelBuilder.Entity<Organization>().Property(org => org.IsDeleted).HasColumnName("IsDeleted").HasColumnType("bit").HasDefaultValue(false);

            modelBuilder.Entity<Category>().ToTable("categories", "charity").HasKey(cat => cat.CategoryId);
            modelBuilder.Entity<Category>()
                .HasMany(cat => cat.Subcategories)
                .WithOne(sub => sub.Category)
                .HasForeignKey(sub => sub.CategoryId)
                .IsRequired();
            modelBuilder.Entity<Category>().Property(cat => cat.CategoryId).HasColumnName("category_id");
            modelBuilder.Entity<Category>().Property(cat => cat.Description).HasColumnName("description");
            modelBuilder.Entity<Category>().Property(cat => cat.Name).HasColumnName("name");
            modelBuilder.Entity<Category>().Property(cat => cat.MobileIconName).HasColumnName("mobile_icon_name");

            modelBuilder.Entity<Subcategory>().ToTable("subcategories", "charity").HasKey(sub => sub.SubCategoryId);
            modelBuilder.Entity<Subcategory>().Property(sub => sub.CategoryId).HasColumnName("category_id");
            modelBuilder.Entity<Subcategory>().Property(sub => sub.SubCategoryId).HasColumnName("subcategory_id");
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
