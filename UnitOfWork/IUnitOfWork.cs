using Lab08__MarcelloAmayo.Repositories;

namespace Lab08__MarcelloAmayo.UnitOfWork;

public interface IUnitOfWork
{
    IClientRepository Clients { get; }

    IProductRepository Products { get; }

    IOrderRepository Orders { get; }

    IOrderDetailRepository OrderDetail { get; }
}