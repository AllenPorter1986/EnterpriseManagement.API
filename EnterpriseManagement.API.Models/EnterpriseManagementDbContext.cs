using EnterpriseManagement.API.Models.Inventory;
using EnterpriseManagement.API.Models.Fulfillment;
using EnterpriseManagement.API.Models.Time;
using System.Data.Entity;
using System;
using EnterpriseManagement.API.Shared;
using System.Linq;
using System.Data.Entity.Infrastructure;
using EnterpriseManagement.API.Shared.Attributes;
using System.Collections.Generic;

namespace EnterpriseManagement.API.Models
{

    public class EnterpriseManagementDbContext : DbContext
    {
        public EnterpriseManagementDbContext() : base(Constants.DatabaseConnectionString)
        {
            Database.SetInitializer<EnterpriseManagementDbContext>(null);

            this.Configuration.LazyLoadingEnabled = false;

            ((IObjectContextAdapter)this).ObjectContext.ObjectMaterialized += (sender, e) => DateTimeKindAttribute.Apply(e.Entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(e =>
            {
                var schema = e.ClrType.Namespace.Split('.').Last().ToLower();

                if (schema.Equals("models", StringComparison.OrdinalIgnoreCase))
                    return;

                var name = e.ClrType.Name;

                e.ToTable(name, schema);
            });

            modelBuilder.Properties<DateTime?>()
                .Configure(property => property.HasColumnType("datetime2"));

            modelBuilder.Properties<DateTime>()
                .Configure(property => property.HasColumnType("datetime2"));

            modelBuilder.Properties<decimal>()
                .Configure(property => property.HasPrecision(19, 8));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            DateTime time = DateTime.UtcNow;

            List<DbEntityEntry> entities = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity).ToList();

            foreach (DbEntityEntry entry in entities.Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property(nameof(BaseEntity.CreatedDateTime)).CurrentValue = time;
                        break;
                    case EntityState.Modified:
                        entry.Property(nameof(BaseEntity.UpdatedDateTime)).CurrentValue = time;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChanges();
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
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationVector> LocationVectors { get; set; }
        public virtual DbSet<Aisle> Aisles { get; set; }
        public virtual DbSet<AisleVector> AisleVectors { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<BuildingVector> BuildingVectors { get; set; }
        public virtual DbSet<Obstacle> Obstacles { get; set; }
        public virtual DbSet<ObstacleVector> ObstacleVectors { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteVector> SiteVectors { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<ItemLocationOrderItem> ItemLocationOrderItems { get; set; }

    }

}
