using Api.Models;
using Claims.Infrastructure.Persistence;

namespace Api.Services;

public class OrderService
{
    private readonly OrderContext _context;

    public OrderService(OrderContext context)
    {
        _context = context;
    }

    public Order? GetOrder(Guid id)
    {
        return _context.Orders.Where(x => x.Id == id).FirstOrDefault();
    }

    public List<Order>? GetOrders()
    {
        return _context.Orders.ToList();
    }

    public void CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}
