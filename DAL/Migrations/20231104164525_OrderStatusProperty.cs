using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrderStatusProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "d0daee38-055f-4f33-8dcb-672ed86270db",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "514a531b-dedb-4360-b847-45b1c48899eb")
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
                oldDefaultValue: new DateTime(2023, 11, 3, 17, 37, 53, 825, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "970442da-91fb-4312-b71d-663b71aa55aa",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "6c4a04fe-7593-4962-8ec1-b39491e437da")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrderPositions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "977d2e50-2bcd-457d-a574-3c54fc134827",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "bb81a2b6-88b7-47dc-be4c-0135e779ad08")
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
                oldDefaultValue: "2c8109e7-33e3-477e-8665-85dd603c6f4e")
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
                oldDefaultValue: "c9031d6c-84eb-4315-9af4-9da33ed66d9a")
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
                oldDefaultValue: "2b7fcf2f-6e04-4dee-9429-40ea05c7114e")
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
                oldDefaultValue: new DateTime(2023, 11, 3, 17, 37, 53, 824, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a12a7733-c96e-4f0e-85f7-a6631291240d",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "8d7a0e5f-5c31-40a4-b00e-e7d136e0ae73")
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
                oldDefaultValue: "6c5409b4-08db-47f2-852e-6cc49460b02c")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "514a531b-dedb-4360-b847-45b1c48899eb",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "d0daee38-055f-4f33-8dcb-672ed86270db")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 3, 17, 37, 53, 825, DateTimeKind.Utc).AddTicks(6601),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 522, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "6c4a04fe-7593-4962-8ec1-b39491e437da",
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
                defaultValue: "bb81a2b6-88b7-47dc-be4c-0135e779ad08",
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
                defaultValue: "2c8109e7-33e3-477e-8665-85dd603c6f4e",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "2e9eef51-20e3-4c6c-8772-1b3db42e602a")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "c9031d6c-84eb-4315-9af4-9da33ed66d9a",
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
                defaultValue: "2b7fcf2f-6e04-4dee-9429-40ea05c7114e",
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
                defaultValue: new DateTime(2023, 11, 3, 17, 37, 53, 824, DateTimeKind.Utc).AddTicks(9245),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 4, 16, 45, 25, 521, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "8d7a0e5f-5c31-40a4-b00e-e7d136e0ae73",
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
                defaultValue: "6c5409b4-08db-47f2-852e-6cc49460b02c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "440d263b-bf88-4d7e-9898-cf1efc5c7a26")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
