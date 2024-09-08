using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sushil_AssignmentTest.Areas.Identity.Data;
using Sushil_AssignmentTest.Models;

namespace Sushil_AssignmentTest.Areas.Identity.Data;

public class DataBaseContext : IdentityDbContext<ApplicationUser>
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    {
    }

    public DbSet<Customer_Info>Customer_Infos { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<District> Districts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserConfigration());
        builder.ApplyConfiguration(new AppCustomerModel());
        builder.ApplyConfiguration(new GenderModel());
        builder.ApplyConfiguration(new StateModel());
        builder.ApplyConfiguration(new DistrictModel());
    }
}

public class DistrictModel : IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.Property(x=>x.GenderName).IsRequired();
    }
}

public class StateModel : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.Property(x => x.StateName).IsRequired();
    }
}

public class GenderModel : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.Property(x => x.DistrictName).IsRequired();
        
    }
}

public class AppCustomerModel : IEntityTypeConfiguration<Customer_Info>
{
    public void Configure(EntityTypeBuilder<Customer_Info> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.HasOne(x => x.Gender).WithMany(x => x.Customer)
         .HasForeignKey(x => x.GenderId).HasConstraintName("FK_Customer_infoToGender");
    }
}

public class ApplicationUserConfigration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.DomainName);
    }
}