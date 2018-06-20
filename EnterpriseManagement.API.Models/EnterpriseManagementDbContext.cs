using EnterpriseManagement.API.Models.Inventory;
using EnterpriseManagement.API.Models.Fulfillment;
using EnterpriseManagement.API.Models.Time;
using System.Data.Entity;

using EnterpriseManagement.API.Shared;

namespace EnterpriseManagement.API.Models
{

    public class EnterpriseManagementDbContext : DbContext
    {
        public EnterpriseManagementDbContext()
            : base(Constants.DatabaseConnectionString)
        {
            Database.SetInitializer<EnterpriseManagementDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new BaseEntityConfiguration());
            //modelBuilder.Entity<TimeSheet>().HasKey(i => new { i.RecordId, i.TimeSheetId });
            //modelBuilder.Entity<ItemLocation>().HasKey(i => new { i.ItemId, i.LocationId });
            //modelBuilder.Entity<ItemLocationOrderItem>().HasKey(i => new { i.ItemLocationId, i.OrderDetailId });

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        //TimeSheet Management
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }        
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Function> Functions { get; set; }

        //Order Management
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        //Inventory Management
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemLocation> ItemLocations { get; set; }
        public virtual DbSet<Aisle> Aisles { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Obstacle> Obstacles { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<ItemLocationOrderItem> ItemLocationOrderItems { get; set; }

    }

}
