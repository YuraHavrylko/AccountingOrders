using System.Data.Entity;
using AccountingOrders.Models;

namespace AccountingOrders.DataBase
{
    public class Context : DbContext
    {
        public Context()
             : base("Server=(local); Integrated Security=true; Database=AccountingOrders")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<OrderModel> OrderModels { get; set; }
        public DbSet<OrderItemModel> OrderItemModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OrderItemModel>().HasRequired<OrderModel>(p => p.OrderModel)
                //.WithMany(b => b.OrderItemModels);
        }
    }
}