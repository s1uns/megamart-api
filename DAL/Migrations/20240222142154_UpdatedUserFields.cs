using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Site",
                table: "Sellers",
                newName: "WebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "Sellers",
                newName: "ProfilePicUrl");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "6b31dfe0-1fd0-41c3-9be7-1d0ffe405961",
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
                defaultValue: new DateTime(2024, 2, 22, 14, 21, 54, 787, DateTimeKind.Utc).AddTicks(2766),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 90, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0d2cb51d-0b20-4012-90b8-b1690dedc0d4",
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
                defaultValue: "d0e7d0bb-7935-4319-babd-cb7d814bd19c",
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
                defaultValue: "f673e8e4-4152-4f8a-b65a-09f85384e37c",
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
                defaultValue: "41d0e967-daa6-4103-9bf9-e5052ea59d85",
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
                defaultValue: "35ae939c-b219-4773-a0c3-efbd0416ca13",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9fb250a4-13a0-4c1f-9be4-556e4611922d")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 21, 54, 786, DateTimeKind.Utc).AddTicks(5478),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 89, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "29fc45b1-a5fd-4062-9a0e-5a699f884a71",
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
                defaultValue: "ccbd1ccb-1bf0-4fa3-ba6a-dbe5fc45f6d8",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "2b0a10d0-b2ba-451d-8262-0df056e6d172")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WebsiteUrl",
                table: "Sellers",
                newName: "Site");

            migrationBuilder.RenameColumn(
                name: "ProfilePicUrl",
                table: "Sellers",
                newName: "LogoUrl");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "465035f7-7890-4f84-90c8-025debf42af6",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "6b31dfe0-1fd0-41c3-9be7-1d0ffe405961")
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
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 21, 54, 787, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "f2ca8fe8-433d-44d7-968c-61756de4f55c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "0d2cb51d-0b20-4012-90b8-b1690dedc0d4")
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
                oldDefaultValue: "d0e7d0bb-7935-4319-babd-cb7d814bd19c")
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
                oldDefaultValue: "f673e8e4-4152-4f8a-b65a-09f85384e37c")
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
                oldDefaultValue: "41d0e967-daa6-4103-9bf9-e5052ea59d85")
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
                oldDefaultValue: "35ae939c-b219-4773-a0c3-efbd0416ca13")
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
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 21, 54, 786, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "942899ed-639f-4e37-8157-72608bc58d7c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "29fc45b1-a5fd-4062-9a0e-5a699f884a71")
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
                oldDefaultValue: "ccbd1ccb-1bf0-4fa3-ba6a-dbe5fc45f6d8")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
