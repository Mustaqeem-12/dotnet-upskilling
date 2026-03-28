using LuLuMall.Data;
using LuLuMall.Models;
using Microsoft.EntityFrameworkCore;


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

        public async Task<List<Product>> GetFilteredProducts(string? search, int page, int pageSize, string? sort)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p =>p.ItemName.Contains(search) ||p.Category.Contains(search));
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "price_asc")query = query.OrderBy(p => p.Price);
                else if (sort == "price_desc")query = query.OrderByDescending(p => p.Price);
            }
            return await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id)!;
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
