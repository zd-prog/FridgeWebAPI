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
    public class ModelConfiguration : IEntityTypeConfiguration<FridgeModel>
    {
        public void Configure(EntityTypeBuilder<FridgeModel> builder)
        {
            builder.HasData
                (
                    new FridgeModel
                    {
                        Id = new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"),
                        Name = "Indesit TIA 140",
                        Year = 2021
                    }, 
                    new FridgeModel
                    {
                        Id = new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"),
                        Name = "LG GA-B509MAUM",
                        Year = 2021
                    },
                    new FridgeModel
                    {
                        Id = new Guid("89a3a07c-3094-4fba-89e6-cf5f51ba1d62"),
                        Name = "BOSCH KGN39AI33R",
                        Year = 2021
                    }
                );
        }
    }
}
