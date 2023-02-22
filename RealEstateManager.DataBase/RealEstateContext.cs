using Microsoft.EntityFrameworkCore;
using RealEstateManager.DataBase.Models;
using Property = Microsoft.EntityFrameworkCore.Metadata.Internal.Property;

namespace RealEstateManager.DataBase;

public class RealEstateContext : DbContext
{
    public RealEstateContext(DbContextOptions<RealEstateContext> dbContextOptions) : base(dbContextOptions)
    {
    }
    
    public DbSet<Property> Properties { get; set; }
    public DbSet<Payment> Payments { get; set; }
}