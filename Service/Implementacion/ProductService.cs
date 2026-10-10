using Lab08__MarcelloAmayo.Models;
using Lab08__MarcelloAmayo.UnitOfWork;

namespace Lab08__MarcelloAmayo.Service.Implementacion;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<List<Product>> PrecioMayorAsync(decimal precio)
    {
        return _unitOfWork.Products
            .PrecioMayorAsync(precio);
    }

    public Task<Product?> ProductoMasCaroAsync()
    {
        return _unitOfWork.Products
            .ProductoMasCaroAsync();
    }

    public Task<decimal> PrecioPromedioAsync()
    {
        return _unitOfWork.Products
            .PrecioPromedioAsync();
    }

    public Task<List<Product>> ProductosSinDescripcionAsync()
    {
        return _unitOfWork.Products
            .ProductosSinDescripcionAsync();
    }

    public Task<List<object>> ProductosPorClienteAsync(int clientId)
    {
        return _unitOfWork.Products
            .ProductosPorClienteAsync(clientId);
    }
}