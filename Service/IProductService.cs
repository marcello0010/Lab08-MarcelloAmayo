using Lab08__MarcelloAmayo.Models;

namespace Lab08__MarcelloAmayo.Service;

public interface IProductService
{
    Task<List<Product>> PrecioMayorAsync(decimal precio);

    Task<Product?> ProductoMasCaroAsync();

    Task<decimal> PrecioPromedioAsync();

    Task<List<Product>> ProductosSinDescripcionAsync();

    Task<List<object>> ProductosPorClienteAsync(int clientId);
}