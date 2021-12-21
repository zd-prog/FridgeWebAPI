using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class FridgeProductsConfiguration : IEntityTypeConfiguration<FridgeProducts>
    {
        public void Configure(EntityTypeBuilder<FridgeProducts> builder)
        {
            builder.HasData
                (
                    new FridgeProducts
                    {
                        Id = new Guid("d87318a2-c6ef-449b-855e-9ba1627bb1e3"),
                        FridgeId = new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"),
                        ProductId = new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("7d0ba280-d0cf-4eae-9d5c-b96e7dfe9d21"),
                        FridgeId = new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"),
                        ProductId = new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("46f2ebd4-1c04-404c-91cd-9a79b818871b"),
                        FridgeId = new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"),
                        ProductId = new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("4638f438-525e-4c43-9626-dd598a2f9cbb"),
                        FridgeId = new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"),
                        ProductId = new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("9df1f915-92d1-4169-b4af-52304b1d6d78"),
                        FridgeId = new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"),
                        ProductId = new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("a3fe58e2-a4cd-478c-9825-2fb3ee4b25df"),
                        FridgeId = new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"),
                        ProductId = new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("baf54fd7-f7b2-4db9-a3b3-8b7cb5fd8f68"),
                        FridgeId = new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"),
                        ProductId = new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("cf43436c-85b8-4cdd-bf3a-651408fbf25b"),
                        FridgeId = new Guid("6967eb7d-100f-4855-b512-14679298a40b"),
                        ProductId = new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("9244e4e6-defc-40d2-b798-9b1032e4779f"),
                        FridgeId = new Guid("6967eb7d-100f-4855-b512-14679298a40b"),
                        ProductId = new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"),
                        Quantity = 10
                    },
                    new FridgeProducts
                    {
                        Id = new Guid("ba6aa62d-501f-452b-8d1f-9e87d5eaf319"),
                        FridgeId = new Guid("6967eb7d-100f-4855-b512-14679298a40b"),
                        ProductId = new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"),
                        Quantity = 10
                    }
                );
        }
    }
}
