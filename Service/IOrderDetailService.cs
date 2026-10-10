namespace Lab08__MarcelloAmayo.Service;

public interface IOrderDetailService
{
    Task<List<object>> DetalleOrdenAsync(int orderId);

    Task<int> CantidadTotalAsync(int orderId);
}