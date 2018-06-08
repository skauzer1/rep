using Microsoft.EntityFrameworkCore;
using Store.Data.Entities;

namespace Store.Data {
    public class StoreContext : DbContext {
        public DbSet<Nomenclature> Nomenclature { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }
}
