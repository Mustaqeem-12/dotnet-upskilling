using Microsoft.EntityFrameworkCore;
using JewelleryApp.Models;

namespace JewelleryApp.Data
{
    public class JewelleryDbContext : DbContext
    {
        public JewelleryDbContext(DbContextOptions<JewelleryDbContext> options)
            : base(options)
        {
        }

        public DbSet<jewel> jewels { get; set; }
    }
}
