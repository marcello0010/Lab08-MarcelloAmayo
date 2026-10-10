using Lab08__MarcelloAmayo.Data;
using Lab08__MarcelloAmayo.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08__MarcelloAmayo.Repositories.Implementacion;

public class ProductRepository
    : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context)
        : base(context)
    {
    }

    public async Task<List<Product>> PrecioMayorAsync(decimal precio)
    {
        return await _context.Products
            .Where(p => p.Price > precio)
            .ToListAsync();
    }

    public async Task<Product?> ProductoMasCaroAsync()
    {
        return await _context.Products
            .OrderByDescending(p => p.Price)
            .FirstOrDefaultAsync();
    }

    public async Task<decimal> PrecioPromedioAsync()
    {
        return await _context.Products
            .Select(p => p.Price)
            .AverageAsync();
    }

    public async Task<List<Product>> ProductosSinDescripcionAsync()
    {
        return await _context.Products
            .Where(p => string.IsNullOrEmpty(p.Description))
            .ToListAsync();
    }

    public async Task<List<object>> ProductosPorClienteAsync(int clientId)
    {
        var datos = await _context.Orders
            .Where(o => o.Clientid == clientId)
            .SelectMany(o => o.Orderdetails)
            .Select(d => new
            {
                d.Product.Productid,
                d.Product.Name,
                d.Product.Price
            })
            .Distinct()
            .ToListAsync();

        return datos.Cast<object>().ToList();
    }
}