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
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product
                    {
                        Id = new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"),
                        Name = "Картофель",
                        DefaultQuantity = 3
                    },
                    new Product
                    {
                        Id = new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"),
                        Name = "Морковь",
                        DefaultQuantity = 5
                    },
                    new Product
                    {
                        Id = new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"),
                        Name = "Яблоки",
                        DefaultQuantity = 9
                    },
                    new Product
                    {
                        Id = new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"),
                        Name = "Свекла",
                        DefaultQuantity = 3
                    },
                    new Product
                    {
                        Id = new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"),
                        Name = "Бананы",
                        DefaultQuantity = 6
                    }
                );
        }
    }
}
