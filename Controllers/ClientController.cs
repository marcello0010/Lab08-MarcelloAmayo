using Lab08__MarcelloAmayo.Service;
using Microsoft.AspNetCore.Mvc;

namespace Lab08__MarcelloAmayo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _service;

    public ClientController(IClientService service)
    {
        _service = service;
    }

    [HttpGet("buscar-por-nombre")]
    public async Task<IActionResult> BuscarPorNombre(string nombre)
    {
        return Ok(
            await _service.BuscarPorNombreAsync(nombre)
        );
    }

    [HttpGet("cliente-mas-pedidos")]
    public async Task<IActionResult> ClienteMasPedidos()
    {
        return Ok(
            await _service.ClienteConMasPedidosAsync()
        );
    }

    [HttpGet("clientes-por-producto")]
    public async Task<IActionResult> ClientesPorProducto(int productId)
    {
        return Ok(
            await _service.ClientesPorProductoAsync(productId)
        );
    }
}