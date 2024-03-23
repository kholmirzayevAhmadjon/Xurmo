using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Xurmo.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CadegoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CadegoryId",
                        column: x => x.CadegoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    User_id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8383), null, false, "Fruits", null },
                    { 2L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8387), null, false, "DairyProducts", null },
                    { 3L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8389), null, false, "Sweets", null },
                    { 4L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8390), null, false, "MeatProducts", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CadegoryId", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8550), null, "This is Apple", false, "Apple", 12990m, null },
                    { 2L, 1L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8552), null, "This is Fig", false, "Fig", 32990m, null },
                    { 3L, 1L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8554), null, "This is Pear", false, "Pear", 19990m, null },
                    { 4L, 2L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8556), null, "This is Carrot", false, "Carrot", 4990m, null },
                    { 5L, 2L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8558), null, "This is Potatoes", false, "Potatoes", 6990m, null },
                    { 6L, 3L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8559), null, "This is Chocolate Nestle", false, "ChocolateNestle", 10990m, null },
                    { 7L, 3L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8563), null, "This is Cace", false, "Cake", 129990m, null },
                    { 8L, 4L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8565), null, "This is Mutton", false, "Mutton", 100990m, null },
                    { 9L, 4L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8567), null, "This is Beef", false, "Beef", 105990m, null },
                    { 10L, 4L, new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8568), null, "This is Sausage", false, "Sausage", 72990m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_User_id",
                table: "Orders",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CadegoryId",
                table: "Products",
                column: "CadegoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
