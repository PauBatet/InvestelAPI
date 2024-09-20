using Microsoft.EntityFrameworkCore;

namespace Investel.Models{
    public class InvestelContext : DbContext
    {
        public InvestelContext(DbContextOptions<InvestelContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}