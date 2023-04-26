using API.NET7.Entitys;
using API.NET7.Models;

namespace API.NET7.Services
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(int id);
        Product GetProduct(int id);
        List<Product> GetProducts();
        void UpdateProduct(ProductModel product);
    }
}