using Lab08__MarcelloAmayo.Data;
using Lab08__MarcelloAmayo.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08__MarcelloAmayo.Repositories.Implementacion;

public class OrderDetailRepository
    : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext context)
        : base(context)
    {
    }

    public async Task<List<object>> DetalleOrdenAsync(int orderId)
    {
        var datos = await _context.OrderDetail
            .Where(d => d.Orderid == orderId)
            .Select(d => new
            {
                Producto = d.Product.Name,
                Cantidad = d.Quantity
            })
            .ToListAsync();

        return datos.Cast<object>().ToList();
    }

    public async Task<int> CantidadTotalAsync(int orderId)
    {
        return await _context.OrderDetail
            .Where(d => d.Orderid == orderId)
            .Select(d => d.Quantity)
            .SumAsync();
    }
}