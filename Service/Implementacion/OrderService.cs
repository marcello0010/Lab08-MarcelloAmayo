using Lab08__MarcelloAmayo.Models;
using Lab08__MarcelloAmayo.UnitOfWork;

namespace Lab08__MarcelloAmayo.Service.Implementacion;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<List<Order>> PedidosDespuesDeFechaAsync(DateTime fecha)
    {
        return _unitOfWork.Orders
            .PedidosDespuesDeFechaAsync(fecha);
    }

    public Task<List<object>> PedidosConDetallesAsync()
    {
        return _unitOfWork.Orders
            .PedidosConDetallesAsync();
    }
}