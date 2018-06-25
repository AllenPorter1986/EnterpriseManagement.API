using System;
using AutoMapper;

namespace EnterpriseManagement.API
{
    public static class MappingConfigurator
    {
        public static IMapper CreateMap()
        {
            var config = new MapperConfiguration(c =>
            {
                AddInventoryMappings(c);
            });


            return config.CreateMapper();
        }

        private static void AddInventoryMappings(IMapperConfigurationExpression c)
        {
            AddMappings<ServiceModels.Inventory.Site, Models.Inventory.Site>(c);
            AddMappings<ServiceModels.Inventory.Building, Models.Inventory.Building>(c);

            //Vectors
            AddMappings<ServiceModels.Inventory.Vector, Models.Inventory.SiteVector>(c);
            AddMappings<ServiceModels.Inventory.Vector, Models.Inventory.BuildingVector>(c);
            AddMappings<ServiceModels.Inventory.Vector, Models.Inventory.AisleVector>(c);
            AddMappings<ServiceModels.Inventory.Vector, Models.Inventory.LocationVector>(c);
            AddMappings<ServiceModels.Inventory.Vector, Models.Inventory.ObstacleVector>(c);
        }

        private static void AddMappings<T, F>(IMapperConfigurationExpression c) where T : ServiceModels.BaseModel where F : Models.BaseEntity
        {
            c.CreateMap<T, F>();
            c.CreateMap<F, T>();
        }

    }
}