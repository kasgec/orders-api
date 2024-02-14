using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrdersController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("/{id}")]
    public Order? GetOrder(Guid id)
    {
        return _orderService.GetOrder(id);
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        var order = _orderService.GetOrders();

        return Ok(order);
    }

    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        order.Created = DateTime.Now;
        _orderService.CreateOrder(order);

        return Ok();
    }
}
