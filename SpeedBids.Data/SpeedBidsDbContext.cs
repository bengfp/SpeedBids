using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeedBids.Entities;

namespace SpeedBids.Data;

public class SpeedBidsDbContext : IdentityDbContext<ApplicationUser>
{
    public SpeedBidsDbContext(DbContextOptions<SpeedBidsDbContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<CarAuction> Auctions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryProduct> CategoryProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sales> Sales { get; set; }

    public DbSet<Bid> Bids { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "admin", NormalizedName = "admin".ToUpper() });
        builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "user", NormalizedName = "user".ToUpper() });

        builder.Entity<Product>()
            .HasOne<Car>()
            .WithOne()
            .HasForeignKey<Car>(aProduct => aProduct.CarId)
            .IsRequired();

        builder.Entity<Category>()
            .HasMany(aCategory => aCategory.Products)
            .WithMany(aProduct => aProduct.Categories)
            .UsingEntity<CategoryProduct>();

        builder.Entity<CarAuction>()
            .HasMany(aCarAuction => aCarAuction.Products)
            .WithMany();

        builder.Entity<CarAuction>()
            .HasMany(aCarAuction => aCarAuction.Bids)
            .WithOne(aBid => aBid.CarAuction)
            .HasForeignKey(aBid => aBid.CarAuctionId);

        builder.Entity<Bid>()
            .HasOne(aBid => aBid.CarAuction)
            .WithMany(aCarAuction => aCarAuction.Bids)
            .HasForeignKey(aBid => aBid.CarAuctionId);

        builder.Entity<ApplicationUser>()
            .HasMany(anUser => anUser.Bids)
            .WithOne(aBid => aBid.User);

        builder.Entity<Bid>()
            .HasOne(aBid => aBid.User)
            .WithMany(anUser => anUser.Bids)
            .HasForeignKey(aBid => aBid.UserId)
            .HasPrincipalKey(anApplicationUser => anApplicationUser.Id);

        builder.Entity<Sales>()
            .HasMany(aSales => aSales.Bids)
            .WithOne()
            .IsRequired();

    }
}
