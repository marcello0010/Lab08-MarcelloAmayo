using Lab08__MarcelloAmayo.Data;
using Lab08__MarcelloAmayo.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08__MarcelloAmayo.Repositories.Implementacion;

public class OrderRepository
    : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context)
        : base(context)
    {
    }

    public async Task<List<Order>> PedidosDespuesDeFechaAsync(DateTime fecha)
    {
        return await _context.Orders
            .Where(o => o.Orderdate > fecha)
            .ToListAsync();
    }

    public async Task<List<object>> PedidosConDetallesAsync()
    {
        var datos = await _context.OrderDetail
            .Select(d => new
            {
                d.Orderid,
                Producto = d.Product.Name,
                Cantidad = d.Quantity
            })
            .ToListAsync();

        return datos.Cast<object>().ToList();
    }
}