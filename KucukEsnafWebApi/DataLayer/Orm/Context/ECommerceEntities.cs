using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Orm.Context
{
    public class ECommerceEntities :DbContext
    {
        public ECommerceEntities()
        {
            Database.Connection.ConnectionString = @"server=xxxxxxxx;uid=xxxxxxx;pwd=xxxxxx;database=ECommerce";
        }
        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Customers> Customers { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        public virtual DbSet<Orders> Orders { get; set; }

        public virtual DbSet<Payment> Payment { get; set; }

        public virtual DbSet<Products> Products { get; set; }

        public virtual DbSet<Shippers> Shippers { get; set; }

        public virtual DbSet<Supplier> Suppliers { get; set; }

        public virtual DbSet<UnderCategory> UnderCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
