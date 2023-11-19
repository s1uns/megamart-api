using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class GoodOptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "fbb8ee73-55e1-42e7-bdcd-a15a649ba841",
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
                defaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 232, DateTimeKind.Utc).AddTicks(3572),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 779, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "419fca40-6f7b-4591-a388-7835a94931a6",
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
                defaultValue: "2f1273ac-a0bb-431c-8c60-21f7b2b4324d",
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
                defaultValue: "0540d1b6-9e15-4696-ad2d-d5cfa0a45e6c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9c518980-99a2-493d-a75e-1f3b941ef8ba")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Goods",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "DeliveryMethods",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "dad90ff1-a202-4700-850b-10b9083c83d8",
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
                defaultValue: "8474df8a-bfed-45e2-859e-3288bfe06c74",
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
                defaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 231, DateTimeKind.Utc).AddTicks(6476),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 778, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "81b7c3d6-3820-4a44-9cb2-db8625670a49",
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
                defaultValue: "a90cc5b6-3e92-4730-8fcb-4403852e0e11",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "52cd5c10-6e2c-4d23-aab9-0fd6ca4336a9")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GoodOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GoodId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Option = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodOptions_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GoodOptions_GoodId",
                table: "GoodOptions",
                column: "GoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodOptions");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Goods");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "3297496a-919f-44dc-ab33-fcf262c0996f",
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
                defaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 779, DateTimeKind.Utc).AddTicks(5683),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 232, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "98f445d1-3b68-471e-b93b-a29022551fff",
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
                defaultValue: "60b7f59c-ad9a-46cd-a289-8de854f6f898",
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
                defaultValue: "9c518980-99a2-493d-a75e-1f3b941ef8ba",
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
                defaultValue: "8d73c905-c4ee-4c39-892d-bbccb7b9b870",
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
                defaultValue: "c9099200-9d46-4bf6-8d56-b331a216ffe8",
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
                defaultValue: new DateTime(2023, 11, 10, 21, 58, 56, 778, DateTimeKind.Utc).AddTicks(8402),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 11, 19, 7, 21, 0, 231, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "50791f34-d933-4ccb-a504-ccd2296e094d",
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
                defaultValue: "52cd5c10-6e2c-4d23-aab9-0fd6ca4336a9",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a90cc5b6-3e92-4730-8fcb-4403852e0e11")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
