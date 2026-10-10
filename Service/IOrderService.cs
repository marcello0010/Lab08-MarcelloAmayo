using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Service;

public interface IOrderService
{
    Task<List<Order>> PedidosDespuesDeFechaAsync(DateTime fecha);

    Task<List<object>> PedidosConDetallesAsync();
}