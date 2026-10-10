using Lab08__MarcelloAmayo.Repositories;

namespace Lab08__MarcelloAmayo.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    public IClientRepository Clients { get; }

    public IProductRepository Products { get; }

    public IOrderRepository Orders { get; }

    public IOrderDetailRepository OrderDetail { get; }

    public UnitOfWork(
        IClientRepository clients,
        IProductRepository products,
        IOrderRepository orders,
        IOrderDetailRepository orderDetails)
    {
        Clients = clients;
        Products = products;
        Orders = orders;
        OrderDetail = orderDetails;
    }
}