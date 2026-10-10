using Lab08__MarcelloAmayo.UnitOfWork;
using Lab08__MarcelloAmayo.Service;

namespace Lab08__MarcelloAmayo.Service.Implementacion;

public class OrderDetailService : IOrderDetailService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderDetailService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<List<object>> DetalleOrdenAsync(int orderId)
    {
        return _unitOfWork.OrderDetail
            .DetalleOrdenAsync(orderId);
    }

    public Task<int> CantidadTotalAsync(int orderId)
    {
        return _unitOfWork.OrderDetail
            .CantidadTotalAsync(orderId);
    }
}