using EnterpriseManagement.Models.InventoryManagement;
using EnterpriseManagement.Models.OrderManagement;
using EnterpriseManagement.Models.TimeManagement;
using System.Data.Entity;

namespace EnterpriseManagement.Models
{

    public class EnterpriseManagementDbContext : DbContext
    {
        public EnterpriseManagementDbContext()
            : base("Name=EnterpriseManagement")
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
        public virtual DbSet<TimeSheetRecord> TimeSheetRecords { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

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
