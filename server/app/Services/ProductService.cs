using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using app.Models;
using app.Data;
using MongoDB.Driver;

namespace app.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
    }
    public class ProductService : IProductService
    {
        private readonly AppContext _context;
        public ProductService(IOptions<Settings> settings)
        {
            _context = new AppContext(settings);
        }
        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            return await _context.Products.Find(x=>true).ToListAsync();
        }
    }
    
}