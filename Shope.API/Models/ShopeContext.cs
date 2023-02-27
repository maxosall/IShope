using Microsoft.EntityFrameworkCore;
using Shope.Models;

namespace Shope.API.Models
{
    public class ShopeContext: DbContext
    {
        public ShopeContext(DbContextOptions<ShopeContext> options)
            : base(options) { }

        DbSet<Product> Products { get; set; }
    }
}