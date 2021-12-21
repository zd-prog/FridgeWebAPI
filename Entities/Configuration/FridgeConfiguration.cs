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
    public class FridgeConfiguration : IEntityTypeConfiguration<Fridge>
    {
        public void Configure(EntityTypeBuilder<Fridge> builder)
        {
            builder.HasData
                (
                new Fridge
                {
                    Id = new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"),
                    FridgeModelId = new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"),
                    Name = "Номер 1",
                    OwnerName = "Иван Иванов"
                },
                new Fridge
                {
                    Id = new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"),
                    FridgeModelId = new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"),
                    Name = "Номер 2",
                    OwnerName = "Пётр Петров"
                },
                new Fridge
                {
                    Id = new Guid("6967eb7d-100f-4855-b512-14679298a40b"),
                    FridgeModelId = new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"),
                    Name = "Номер 3",
                    OwnerName = "Пётр Петров"
                },
                new Fridge
                {
                    Id = new Guid("cc0635a1-66f1-4394-b17f-42dbd405e5c1"),
                    FridgeModelId = new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"),
                    Name = "Номер 4",
                    OwnerName = "Иван Иванов"
                },
                new Fridge
                {
                    Id = new Guid("7570a579-4ada-420f-966b-c5e5bcf93f06"),
                    FridgeModelId = new Guid("89a3a07c-3094-4fba-89e6-cf5f51ba1d62"),
                    Name = "Номер 5",
                    OwnerName = "Иван Иванов"
                }
                );
        }
    }
}
