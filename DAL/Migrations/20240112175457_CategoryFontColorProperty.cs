using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategoryFontColorProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Categories",
                newName: "BackgroundColor");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "465035f7-7890-4f84-90c8-025debf42af6",
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
                defaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 90, DateTimeKind.Utc).AddTicks(3102),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 541, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "f2ca8fe8-433d-44d7-968c-61756de4f55c",
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
                defaultValue: "19ffc6f2-d3b1-47d5-8cd0-3ec1cb5649eb",
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
                defaultValue: "29bc9816-d45f-4d77-9a87-5ba66d97cf1b",
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
                defaultValue: "7ed65c67-3996-4f9a-8ebc-b3ea15245848",
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
                defaultValue: "9fb250a4-13a0-4c1f-9be4-556e4611922d",
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
                defaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 89, DateTimeKind.Utc).AddTicks(5779),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 12, 1, 17, 26, 24, 540, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "942899ed-639f-4e37-8157-72608bc58d7c",
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
                defaultValue: "2b0a10d0-b2ba-451d-8262-0df056e6d172",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "3a64cbd9-558e-48eb-8596-0ec00ce45e96")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FontColor",
                table: "Categories",
                type: "longtext",
                nullable: false,
                defaultValue: "000000")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FontColor",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "BackgroundColor",
                table: "Categories",
                newName: "Color");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "d19b8d8f-7268-44d8-afcc-37bac1cf324c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "465035f7-7890-4f84-90c8-025debf42af6")
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
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 90, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "6fe3b082-002d-41e0-8fb0-2bd04559256f",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "f2ca8fe8-433d-44d7-968c-61756de4f55c")
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
                oldDefaultValue: "19ffc6f2-d3b1-47d5-8cd0-3ec1cb5649eb")
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
                oldDefaultValue: "29bc9816-d45f-4d77-9a87-5ba66d97cf1b")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "be3e62f4-2581-4d3e-9db6-92b775ddab2e",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "7ed65c67-3996-4f9a-8ebc-b3ea15245848")
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
                oldDefaultValue: "9fb250a4-13a0-4c1f-9be4-556e4611922d")
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
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 89, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "9c6ff569-d1e0-4d8c-803e-c9aa4f47aeaf",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "942899ed-639f-4e37-8157-72608bc58d7c")
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
                oldDefaultValue: "2b0a10d0-b2ba-451d-8262-0df056e6d172")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
