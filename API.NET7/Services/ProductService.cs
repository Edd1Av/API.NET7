using API.NET7.Data;
using API.NET7.Entitys;
using API.NET7.Models;

namespace API.NET7.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }

        public void CreateProduct(ProductModel product)
        {
            Product productRecord = new()
            {
                Name = product.Name,
                Description = product.Description,
                CreateDate = DateTime.Now,
                Stock = product.Stock
            };

            _context.Products.Add(productRecord);
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductModel product)
        {

            Product productRecord = _context.Products.Find(product.Id);
            if(productRecord == null) {
                

            }
            else
            {
                productRecord.Name = product.Name;
                productRecord.Description = product.Description;
                productRecord.Stock = product.Stock;

                _context.Products.Update(productRecord);
                _context.SaveChanges();
            }
           

        }

        public void DeleteProduct(int id)
        {
            Product productRecord = this.GetProduct(id);
            _context.Products.Remove(productRecord);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();

        }
    }
}
