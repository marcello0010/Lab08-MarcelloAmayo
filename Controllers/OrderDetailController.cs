using Lab08__MarcelloAmayo.Service;
using Microsoft.AspNetCore.Mvc;

namespace Lab08__MarcelloAmayo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderDetailController : ControllerBase
{
    private readonly IOrderDetailService _service;

    public OrderDetailController(IOrderDetailService service)
    {
        _service = service;
    }

    [HttpGet("productos-por-orden")]
    public async Task<IActionResult> ProductosPorOrden(int orderId)
    {
        return Ok(
            await _service.DetalleOrdenAsync(orderId)
        );
    }

    [HttpGet("total-productos")]
    public async Task<IActionResult> TotalProductos(int orderId)
    {
        return Ok(
            await _service.CantidadTotalAsync(orderId)
        );
    }
}