using Microsoft.EntityFrameworkCore;

namespace yummy_tummy.Models
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
         public DbSet<Order> Orders { get; set; }
    }
}