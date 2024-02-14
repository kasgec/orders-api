using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Claims.Infrastructure.Persistence;

public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public OrderContext(DbContextOptions<OrderContext> options) : base(options)
    {
        Orders = Set<Order>();
    }

    public DbSet<T> GetDbSet<T>() where T : class
    {
        return Set<T>();
    }
}
