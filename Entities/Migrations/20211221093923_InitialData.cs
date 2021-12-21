using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "FridgeModelId", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"), "Indesit TIA 140", 2021 },
                    { new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"), "LG GA-B509MAUM", 2021 },
                    { new Guid("89a3a07c-3094-4fba-89e6-cf5f51ba1d62"), "BOSCH KGN39AI33R", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DefaultQuantity", "Name" },
                values: new object[,]
                {
                    { new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"), 3, "Картофель" },
                    { new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"), 5, "Морковь" },
                    { new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"), 9, "Яблоки" },
                    { new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"), 3, "Свекла" },
                    { new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"), 6, "Бананы" }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "FridgeId", "FridgeModelId", "Name", "OwnerName" },
                values: new object[,]
                {
                    { new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"), new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"), "Номер 1", "Иван Иванов" },
                    { new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"), new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"), "Номер 2", "Пётр Петров" },
                    { new Guid("6967eb7d-100f-4855-b512-14679298a40b"), new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"), "Номер 3", "Пётр Петров" },
                    { new Guid("cc0635a1-66f1-4394-b17f-42dbd405e5c1"), new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"), "Номер 4", "Иван Иванов" },
                    { new Guid("7570a579-4ada-420f-966b-c5e5bcf93f06"), new Guid("89a3a07c-3094-4fba-89e6-cf5f51ba1d62"), "Номер 5", "Иван Иванов" }
                });

            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "FridgeProductId", "FridgeId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("d87318a2-c6ef-449b-855e-9ba1627bb1e3"), new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"), new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"), 10 },
                    { new Guid("7d0ba280-d0cf-4eae-9d5c-b96e7dfe9d21"), new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"), new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"), 10 },
                    { new Guid("46f2ebd4-1c04-404c-91cd-9a79b818871b"), new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"), new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"), 10 },
                    { new Guid("4638f438-525e-4c43-9626-dd598a2f9cbb"), new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"), new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"), 10 },
                    { new Guid("9df1f915-92d1-4169-b4af-52304b1d6d78"), new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"), new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"), 10 },
                    { new Guid("a3fe58e2-a4cd-478c-9825-2fb3ee4b25df"), new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"), new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"), 10 },
                    { new Guid("baf54fd7-f7b2-4db9-a3b3-8b7cb5fd8f68"), new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"), new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"), 10 },
                    { new Guid("cf43436c-85b8-4cdd-bf3a-651408fbf25b"), new Guid("6967eb7d-100f-4855-b512-14679298a40b"), new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"), 10 },
                    { new Guid("9244e4e6-defc-40d2-b798-9b1032e4779f"), new Guid("6967eb7d-100f-4855-b512-14679298a40b"), new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"), 10 },
                    { new Guid("ba6aa62d-501f-452b-8d1f-9e87d5eaf319"), new Guid("6967eb7d-100f-4855-b512-14679298a40b"), new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"), 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("4638f438-525e-4c43-9626-dd598a2f9cbb"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("46f2ebd4-1c04-404c-91cd-9a79b818871b"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("7d0ba280-d0cf-4eae-9d5c-b96e7dfe9d21"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("9244e4e6-defc-40d2-b798-9b1032e4779f"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("9df1f915-92d1-4169-b4af-52304b1d6d78"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("a3fe58e2-a4cd-478c-9825-2fb3ee4b25df"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("ba6aa62d-501f-452b-8d1f-9e87d5eaf319"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("baf54fd7-f7b2-4db9-a3b3-8b7cb5fd8f68"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("cf43436c-85b8-4cdd-bf3a-651408fbf25b"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "FridgeProductId",
                keyValue: new Guid("d87318a2-c6ef-449b-855e-9ba1627bb1e3"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("7570a579-4ada-420f-966b-c5e5bcf93f06"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("cc0635a1-66f1-4394-b17f-42dbd405e5c1"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("3f235359-e08e-4571-9e79-2f1f3f36c993"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("6967eb7d-100f-4855-b512-14679298a40b"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("d5f0e29a-0442-4473-9bab-19efa60862f9"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "FridgeModelId",
                keyValue: new Guid("89a3a07c-3094-4fba-89e6-cf5f51ba1d62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("be24a440-b29d-44a5-8f8a-8b59fd546f8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e93ed1cc-812b-4859-9ab4-35fda086337b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ea0e3faf-235f-4cf5-bbde-e536f65f3c95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f11e43fd-1a39-452e-b78f-cbc692f279b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("faf6f6bf-28de-4a00-ace3-460daa990f4c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "FridgeModelId",
                keyValue: new Guid("688cd200-173f-4b66-b27a-92e8b02f7a6e"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "FridgeModelId",
                keyValue: new Guid("ebe98db7-3fc6-49b8-9abc-fb87b4bbcf2a"));
        }
    }
}
