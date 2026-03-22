using LuLuMall.Models;

namespace LuLuMall.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);

        Product GetById(int id);  
        void Update(Product product);
        void Delete(int id);  
    }
}
