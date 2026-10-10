using Lab08__MarcelloAmayo.Data;
using Lab08__MarcelloAmayo.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08__MarcelloAmayo.Repositories.Implementacion;

public class ClientRepository
    : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(AppDbContext context)
        : base(context)
    {
    }

    public async Task<List<Client>> BuscarPorNombreAsync(string nombre)
    {
        return await _context.Clients
            .Where(c => c.Name.Contains(nombre))
            .ToListAsync();
    }

    public async Task<object?> ClienteConMasPedidosAsync()
    {
        return await _context.Orders
            .GroupBy(o => o.Clientid)
            .Select(g => new
            {
                Clientid = g.Key,
                CantidadPedidos = g.Count()
            })
            .OrderByDescending(x => x.CantidadPedidos)
            .FirstOrDefaultAsync();
    }

    public async Task<List<object>> ClientesPorProductoAsync(int productId)
    {
        var datos = await _context.OrderDetail
            .Where(d => d.Productid == productId)
            .Select(d => new
            {
                d.Order.Client.Clientid,
                d.Order.Client.Name,
                d.Order.Client.Email
            })
            .Distinct()
            .ToListAsync();

        return datos.Cast<object>().ToList();
    }
}