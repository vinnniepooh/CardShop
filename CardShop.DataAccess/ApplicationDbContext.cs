using CardShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CardShop.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            
        DbSet<Category> Categories { get; set; }
    }
}