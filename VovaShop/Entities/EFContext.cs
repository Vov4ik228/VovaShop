using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class EFContext : DbContext
    {
        public EFContext() : base("Connection")
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageAddress> StorageAddress { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RecycleBin> RecycleBin { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
