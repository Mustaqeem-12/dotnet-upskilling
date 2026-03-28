using LuLuMall.Models;
using LuLuMall.Repositories;

namespace LuLuMall.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public List<Product> GetProducts()
        {
            return _repo.GetAll();
        }
        public async Task <List<Product>> GetProducts(string? search, int page, int pageSize,string? sort)
        {
            return await _repo.GetFilteredProducts(search,page,pageSize,sort);
        }
        
        public void AddProduct(Product product)
        {
            _repo.Add(product);
        }
        public Product GetProductById(int id)
        {
            return _repo.GetById(id);
        }

        public void UpdateProduct(Product product)

        {
            _repo.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _repo.Delete(id);
        }
    }
}
