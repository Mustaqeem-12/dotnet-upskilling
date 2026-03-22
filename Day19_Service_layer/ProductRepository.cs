using LuLuMall.Data;
using LuLuMall.Models;


namespace LuLuMall.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingDbContext _context;

        public ProductRepository(ShoppingDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.id == id);
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = _context.Products.Find(id);
            if(data != null)
            {
                _context.Products.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
