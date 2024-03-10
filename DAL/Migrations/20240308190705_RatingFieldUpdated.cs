using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class RatingFieldUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "312b0146-b0b1-4e25-8c58-9bfbf7c86730",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c74f8c0a-a2d8-43fe-af47-8e6b54fe4d53")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Ratings",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "834dd13a-daf0-4047-97de-05a888603f34",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "3c20ec65-ff9b-4343-b6e6-ad786cac33b1")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 8, 19, 7, 5, 743, DateTimeKind.Utc).AddTicks(9068),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0f6a1908-c076-4459-9078-303e21a91985",
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
                defaultValue: "edd4ec0d-38d1-45d9-bc09-7d9202e5ea9e",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "5ddf960f-18da-402b-8b6d-b0c71290f3f5")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Goods",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a1bf1689-c28c-4d87-af5c-d4ed2b8b18f7",
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
                defaultValue: new DateTime(2024, 3, 8, 19, 7, 5, 743, DateTimeKind.Utc).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 8, 16, 39, 57, 617, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "9dd1eb4c-6323-4199-8751-5eef86bf2b69",
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
                defaultValue: "42fdaa89-dd3b-42cb-aac8-da0fc7c4fd4f",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0b2632c8-9734-409b-953b-12e0faf51858")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c74f8c0a-a2d8-43fe-af47-8e6b54fe4d53",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "312b0146-b0b1-4e25-8c58-9bfbf7c86730")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Ratings",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "3c20ec65-ff9b-4343-b6e6-ad786cac33b1",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "834dd13a-daf0-4047-97de-05a888603f34")
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
                oldDefaultValue: new DateTime(2024, 3, 8, 19, 7, 5, 743, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c147e854-6435-4f8e-a625-cbcf71a7cafc",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0f6a1908-c076-4459-9078-303e21a91985")
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
                oldDefaultValue: "edd4ec0d-38d1-45d9-bc09-7d9202e5ea9e")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Goods",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "44eeaa51-15c4-48fd-bd71-51a782858029",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a1bf1689-c28c-4d87-af5c-d4ed2b8b18f7")
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
                oldDefaultValue: new DateTime(2024, 3, 8, 19, 7, 5, 743, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "7e4d5c77-3af0-44fa-9937-70e60aa62ee7",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9dd1eb4c-6323-4199-8751-5eef86bf2b69")
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
                oldDefaultValue: "42fdaa89-dd3b-42cb-aac8-da0fc7c4fd4f")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
