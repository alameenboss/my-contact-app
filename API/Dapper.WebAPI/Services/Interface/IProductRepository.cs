using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services.Interface
{
    public interface IProductRepository
    {
        ValueTask<Product> GetById(int id);
        Task AddProduct(Product entity);
        Task UpdateProduct(Product entity, int id);
        Task RemoveProduct(int id);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
