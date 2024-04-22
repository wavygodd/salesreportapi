

using Microsoft.EntityFrameworkCore;
using salesreportapi.Models;

namespace salesreportapi.Dal
{
    public class SalesDbcontext:DbContext
    {
        public SalesDbcontext(DbContextOptions<SalesDbcontext> options) : base(options)
        {
        }


        public DbSet<Sales> Sales { get; set; }
        public DbSet<SaleLines> SaleLines { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sales>().HasKey(s => s.TransactionKey);


            modelBuilder.Entity<Sales>()
                .HasMany(s => s.SaleLines)
                .WithOne(sl => sl.Sales)
                .HasForeignKey(sl => sl.TransactionKey);
        }
    }
}
