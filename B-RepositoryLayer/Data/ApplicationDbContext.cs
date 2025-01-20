using System.Reflection;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace B_RepositoryLayer.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    
    /// to solve design issue in Subscription Entity fK FlatId and (BuildingId)??
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Subscription>()
            .HasOne(s => s.Flat)
            .WithMany()
            .HasForeignKey(s => s.FlatId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Subscription>()
            .HasOne(s => s.Building)
            .WithMany()
            .HasForeignKey(s => s.BuildingId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Cutting_Down_A>()
            .HasOne(c => c.CreatedUser) // Replace SomeEntity with the actual entity
            .WithMany()
            .HasForeignKey(c => c.CreatedUserId) // Replace SomeEntityId with the actual foreign key
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Cutting_Down_A>()
            .HasOne(c => c.UpdatedUser) // Replace SomeEntity with the actual entity
            .WithMany()
            .HasForeignKey(c => c.UpdatedUserId) // Replace SomeEntityId with the actual foreign key
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Cutting_Down_B>()
            .HasOne(c => c.CreatedUser) // Replace SomeEntity with the actual entity
            .WithMany()
            .HasForeignKey(c => c.CreatedUserId) // Replace SomeEntityId with the actual foreign key
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Cutting_Down_B>()
            .HasOne(c => c.UpdatedUser) // Replace SomeEntity with the actual entity
            .WithMany()
            .HasForeignKey(c => c.UpdatedUserId) // Replace SomeEntityId with the actual foreign key
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnType("varchar(256)")
            .HasConversion(v => v.ToLower(), v => v)
            .HasColumnName("email");;

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

            
    }

    
    public DbSet<Governorate> Governorates { get; set; } = null!;
    public DbSet<Sector> Sectors { get; set; } = null!;
    public DbSet<Zone> Zones { get; set; } = null!;
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<Station> Stations { get; set; } = null!;
    public DbSet<Cabin> Cabins { get; set; } = null!;
    public DbSet<Cable> Cables { get; set; } = null!;
    public DbSet<Block> Blocks { get; set; } = null!;
    public DbSet<Building> Buildings { get; set; } = null!;
    public DbSet<Flat> Flats { get; set; } = null!;
    public DbSet<Subscription> Subscriptions { get; set; } = null!;
    
    public DbSet<Cutting_Down_A> Cutting_Down_A { get; set; } = null!;
    public DbSet<Cutting_Down_B> Cutting_Down_B { get; set; } = null!;
    ////////////////////////
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<ProblemType> ProblemTypes { get; set; } = null!;
    public DbSet<Channel> Channels { get; set; } = null!;
    public DbSet<Netwoek_element_Type> Netwoek_Element_Types { get; set; } = null!;
    public DbSet<Network_Element> Network_Elements { get; set; } = null!;

}