using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Repositories;

public interface IClientRepository : IGenericRepository<Client>
{
    Task<List<Client>> BuscarPorNombreAsync(string nombre);
    Task<object?> ClienteConMasPedidosAsync();
    Task<List<object>> ClientesPorProductoAsync(int productId);
}