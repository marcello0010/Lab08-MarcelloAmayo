using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Repositories;

public interface IOrderDetailRepository
    : IGenericRepository<OrderDetail>
{
    Task<List<object>> DetalleOrdenAsync(int orderId);
    Task<int> CantidadTotalAsync(int orderId);
}