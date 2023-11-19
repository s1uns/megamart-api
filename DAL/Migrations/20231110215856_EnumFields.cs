using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class EnumFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "3297496a-919f-44dc-ab33-fcf262c0996f",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "d0daee38-055f-4f33-8dcb-672ed86270db")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Sellers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 779, DateTimeKind.Utc).AddTicks(5683),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 522, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "98f445d1-3b68-471e-b93b-a29022551fff",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "970442da-91fb-4312-b71d-663b71aa55aa")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "60b7f59c-ad9a-46cd-a289-8de854f6f898",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "977d2e50-2bcd-457d-a574-3c54fc134827")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "9c518980-99a2-493d-a75e-1f3b941ef8ba",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "2e9eef51-20e3-4c6c-8772-1b3db42e602a")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityStatus",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreationStatus",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "8d73c905-c4ee-4c39-892d-bbccb7b9b870",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a6b33f43-655d-468c-bf9f-656709880000")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryAddresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c9099200-9d46-4bf6-8d56-b331a216ffe8",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "823c23dd-2886-4303-8c50-7476ffd4e7db")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 778, DateTimeKind.Utc).AddTicks(8402),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 521, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "50791f34-d933-4ccb-a504-ccd2296e094d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a12a7733-c96e-4f0e-85f7-a6631291240d")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "52cd5c10-6e2c-4d23-aab9-0fd6ca4336a9",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "440d263b-bf88-4d7e-9898-cf1efc5c7a26")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "AvailabilityStatus",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "CreationStatus",
                table: "Goods");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "d0daee38-055f-4f33-8dcb-672ed86270db",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "3297496a-919f-44dc-ab33-fcf262c0996f")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 522, DateTimeKind.Utc).AddTicks(4459),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 779, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "970442da-91fb-4312-b71d-663b71aa55aa",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "98f445d1-3b68-471e-b93b-a29022551fff")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "977d2e50-2bcd-457d-a574-3c54fc134827",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "60b7f59c-ad9a-46cd-a289-8de854f6f898")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Goods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "2e9eef51-20e3-4c6c-8772-1b3db42e602a",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9c518980-99a2-493d-a75e-1f3b941ef8ba")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a6b33f43-655d-468c-bf9f-656709880000",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "8d73c905-c4ee-4c39-892d-bbccb7b9b870")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryAddresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "823c23dd-2886-4303-8c50-7476ffd4e7db",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "c9099200-9d46-4bf6-8d56-b331a216ffe8")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime(6)",
                nullable: true,
                defaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 521, DateTimeKind.Utc).AddTicks(7289),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 778, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a12a7733-c96e-4f0e-85f7-a6631291240d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "50791f34-d933-4ccb-a504-ccd2296e094d")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Categories",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "440d263b-bf88-4d7e-9898-cf1efc5c7a26",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "52cd5c10-6e2c-4d23-aab9-0fd6ca4336a9")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
