using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Repositories;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<List<Order>> PedidosDespuesDeFechaAsync(DateTime fecha);
    Task<List<object>> PedidosConDetallesAsync();
}