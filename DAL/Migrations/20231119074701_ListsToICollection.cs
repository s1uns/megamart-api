using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ListsToICollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "11bbe5ad-3ea8-4fd3-b87a-b16c823d250d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "fbb8ee73-55e1-42e7-bdcd-a15a649ba841")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 40, DateTimeKind.Utc).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 232, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c9cc48e5-51a0-4efe-bf85-b5ba7ac99157",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "419fca40-6f7b-4591-a388-7835a94931a6")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "b49c5556-d917-4c2e-8949-a3aa03a09986",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "2f1273ac-a0bb-431c-8c60-21f7b2b4324d")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "4ce3d0c6-e772-4da4-9d10-f8e90518e528",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0540d1b6-9e15-4696-ad2d-d5cfa0a45e6c")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "683d9b39-2e6b-45d7-b67f-9785cde2940c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "dad90ff1-a202-4700-850b-10b9083c83d8")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryAddresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "57685096-40c8-445f-8365-a7b13c52b992",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "8474df8a-bfed-45e2-859e-3288bfe06c74")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 39, DateTimeKind.Utc).AddTicks(5109),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 231, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "199ecef0-2c91-435c-8013-2a6b0f3b7e1a",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "81b7c3d6-3820-4a44-9cb2-db8625670a49")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "bfdc242e-480f-42a1-97fe-8681854906e0",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a90cc5b6-3e92-4730-8fcb-4403852e0e11")
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
                defaultValue: "fbb8ee73-55e1-42e7-bdcd-a15a649ba841",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "11bbe5ad-3ea8-4fd3-b87a-b16c823d250d")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 232, DateTimeKind.Utc).AddTicks(3572),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 40, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "419fca40-6f7b-4591-a388-7835a94931a6",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c9cc48e5-51a0-4efe-bf85-b5ba7ac99157")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "2f1273ac-a0bb-431c-8c60-21f7b2b4324d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "b49c5556-d917-4c2e-8949-a3aa03a09986")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0540d1b6-9e15-4696-ad2d-d5cfa0a45e6c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "4ce3d0c6-e772-4da4-9d10-f8e90518e528")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "dad90ff1-a202-4700-850b-10b9083c83d8",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "683d9b39-2e6b-45d7-b67f-9785cde2940c")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryAddresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "8474df8a-bfed-45e2-859e-3288bfe06c74",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "57685096-40c8-445f-8365-a7b13c52b992")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 231, DateTimeKind.Utc).AddTicks(6476),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 39, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "81b7c3d6-3820-4a44-9cb2-db8625670a49",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "199ecef0-2c91-435c-8013-2a6b0f3b7e1a")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a90cc5b6-3e92-4730-8fcb-4403852e0e11",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "bfdc242e-480f-42a1-97fe-8681854906e0")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
