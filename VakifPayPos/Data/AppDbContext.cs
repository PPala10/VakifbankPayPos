namespace VakifPayPos.Data; 

using Microsoft.EntityFrameworkCore;
using VakifPayPos.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pos> Pos { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerDocument> CustomerDocuments { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Payment> Payments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<CustomerDocument>()
            .HasOne(cd => cd.Customer)
            .WithMany(c => c.CustomerDocuments)
            .HasForeignKey(cd => cd.customerId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o. customerId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.orderId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Pos)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(oi => oi.productId);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Order)
            .WithMany(o => o.Payments)
            .HasForeignKey(p => p.orderId);
    }
}