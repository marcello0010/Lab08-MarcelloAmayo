using Lab08__MarcelloAmayo.Service;
using Microsoft.AspNetCore.Mvc;

namespace Lab08__MarcelloAmayo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet("precio-mayor")]
    public async Task<IActionResult> PrecioMayor(decimal precio)
    {
        return Ok(
            await _service.PrecioMayorAsync(precio)
        );
    }

    [HttpGet("mas-caro")]
    public async Task<IActionResult> MasCaro()
    {
        return Ok(
            await _service.ProductoMasCaroAsync()
        );
    }

    [HttpGet("promedio-precio")]
    public async Task<IActionResult> Promedio()
    {
        return Ok(
            await _service.PrecioPromedioAsync()
        );
    }

    [HttpGet("sin-descripcion")]
    public async Task<IActionResult> SinDescripcion()
    {
        return Ok(
            await _service.ProductosSinDescripcionAsync()
        );
    }

    [HttpGet("productos-por-cliente")]
    public async Task<IActionResult> ProductosPorCliente(int clientId)
    {
        return Ok(
            await _service.ProductosPorClienteAsync(clientId)
        );
    }
}