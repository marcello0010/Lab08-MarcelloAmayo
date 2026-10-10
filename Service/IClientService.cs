using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Service;

public interface IClientService
{
    Task<List<Client>> BuscarPorNombreAsync(string nombre);

    Task<object?> ClienteConMasPedidosAsync();

    Task<List<object>> ClientesPorProductoAsync(int productId);
}