using Lab08__MarcelloAmayo.Service;
using Microsoft.AspNetCore.Mvc;

namespace Lab08__MarcelloAmayo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }

    [HttpGet("despues-de-fecha")]
    public async Task<IActionResult> DespuesDeFecha(DateTime fecha)
    {
        return Ok(
            await _service.PedidosDespuesDeFechaAsync(fecha)
        );
    }

    [HttpGet("pedidos-detalles")]
    public async Task<IActionResult> PedidosDetalles()
    {
        return Ok(
            await _service.PedidosConDetallesAsync()
        );
    }
}