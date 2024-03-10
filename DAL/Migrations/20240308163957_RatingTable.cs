using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class RatingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c74f8c0a-a2d8-43fe-af47-8e6b54fe4d53",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "dad32cac-dd33-499c-94e0-1dd443e9eba6")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(6055),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c147e854-6435-4f8e-a625-cbcf71a7cafc",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "29003ec4-d456-4737-a507-c839c19ba71a")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "5ddf960f-18da-402b-8b6d-b0c71290f3f5",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "83ac8775-cf5d-456a-a873-3abf10abbddb")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "44eeaa51-15c4-48fd-bd71-51a782858029",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c0ea2936-9530-42bc-8ce3-3f4e5aec005f")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(1207),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "7e4d5c77-3af0-44fa-9937-70e60aa62ee7",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0205892c-1c85-4f9a-a1f6-dd6ac81ca047")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0b2632c8-9734-409b-953b-12e0faf51858",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "bc51266a-884a-41c4-b6fc-dd5221114cbc")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "3c20ec65-ff9b-4343-b6e6-ad786cac33b1")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoodId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CustomerId",
                table: "Ratings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_GoodId",
                table: "Ratings",
                column: "GoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "dad32cac-dd33-499c-94e0-1dd443e9eba6",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c74f8c0a-a2d8-43fe-af47-8e6b54fe4d53")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(7553),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "29003ec4-d456-4737-a507-c839c19ba71a",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c147e854-6435-4f8e-a625-cbcf71a7cafc")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "83ac8775-cf5d-456a-a873-3abf10abbddb",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "5ddf960f-18da-402b-8b6d-b0c71290f3f5")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c0ea2936-9530-42bc-8ce3-3f4e5aec005f",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "44eeaa51-15c4-48fd-bd71-51a782858029")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(2486),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0205892c-1c85-4f9a-a1f6-dd6ac81ca047",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "7e4d5c77-3af0-44fa-9937-70e60aa62ee7")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "bc51266a-884a-41c4-b6fc-dd5221114cbc",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0b2632c8-9734-409b-953b-12e0faf51858")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
