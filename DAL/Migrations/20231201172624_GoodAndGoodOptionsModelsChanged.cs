using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class GoodAndGoodOptionsModelsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Option",
                table: "GoodOptions",
                newName: "OptionName");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "d19b8d8f-7268-44d8-afcc-37bac1cf324c",
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
                defaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 541, DateTimeKind.Utc).AddTicks(2105),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 40, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "6fe3b082-002d-41e0-8fb0-2bd04559256f",
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
                defaultValue: "58067c91-c6f8-489f-bdcf-489b1fc223ad",
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
                defaultValue: "8f799748-b5ca-4506-b9c0-74c619a1e488",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "4ce3d0c6-e772-4da4-9d10-f8e90518e528")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "be3e62f4-2581-4d3e-9db6-92b775ddab2e",
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
                defaultValue: "8431159e-caab-418d-b577-42b22c47b52e",
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
                defaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 540, DateTimeKind.Utc).AddTicks(5135),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 47, 1, 39, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "9c6ff569-d1e0-4d8c-803e-c9aa4f47aeaf",
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
                defaultValue: "3a64cbd9-558e-48eb-8596-0ec00ce45e96",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "bfdc242e-480f-42a1-97fe-8681854906e0")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Goods");

            migrationBuilder.RenameColumn(
                name: "OptionName",
                table: "GoodOptions",
                newName: "Option");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "11bbe5ad-3ea8-4fd3-b87a-b16c823d250d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "d19b8d8f-7268-44d8-afcc-37bac1cf324c")
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
                oldDefaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 541, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c9cc48e5-51a0-4efe-bf85-b5ba7ac99157",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "6fe3b082-002d-41e0-8fb0-2bd04559256f")
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
                oldDefaultValue: "58067c91-c6f8-489f-bdcf-489b1fc223ad")
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
                oldDefaultValue: "8f799748-b5ca-4506-b9c0-74c619a1e488")
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
                oldDefaultValue: "be3e62f4-2581-4d3e-9db6-92b775ddab2e")
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
                oldDefaultValue: "8431159e-caab-418d-b577-42b22c47b52e")
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
                oldDefaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 540, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "199ecef0-2c91-435c-8013-2a6b0f3b7e1a",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9c6ff569-d1e0-4d8c-803e-c9aa4f47aeaf")
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
                oldDefaultValue: "3a64cbd9-558e-48eb-8596-0ec00ce45e96")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
