using Lab08__MarcelloAmayo.Models;
using Lab08__MarcelloAmayo.UnitOfWork;

namespace Lab08__MarcelloAmayo.Service.Implementacion;

public class ClientService : IClientService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClientService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<List<Client>> BuscarPorNombreAsync(string nombre)
    {
        return _unitOfWork.Clients
            .BuscarPorNombreAsync(nombre);
    }

    public Task<object?> ClienteConMasPedidosAsync()
    {
        return _unitOfWork.Clients
            .ClienteConMasPedidosAsync();
    }

    public Task<List<object>> ClientesPorProductoAsync(int productId)
    {
        return _unitOfWork.Clients
            .ClientesPorProductoAsync(productId);
    }
}