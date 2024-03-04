using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class NullableUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sellers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "dad32cac-dd33-499c-94e0-1dd443e9eba6",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "afa40f47-d8d6-4df2-87c2-6616c29f36b8")
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
                oldDefaultValue: new DateTime(2024, 3, 2, 19, 20, 41, 602, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "29003ec4-d456-4737-a507-c839c19ba71a",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "e1d9eca5-7a04-4df3-8dac-218dc346e4b4")
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
                oldDefaultValue: "338b8459-1ee4-4e67-bee1-77ab924516fc")
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
                oldDefaultValue: "87f3df1f-fd2d-4a13-b071-a9a483410feb")
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
                oldDefaultValue: new DateTime(2024, 3, 2, 19, 20, 41, 601, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "0205892c-1c85-4f9a-a1f6-dd6ac81ca047",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "9c394084-537c-4d87-96d9-5f0047585970")
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
                oldDefaultValue: "2bb6f915-5225-404f-8e33-19968796eb25")
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
                defaultValue: "afa40f47-d8d6-4df2-87c2-6616c29f36b8",
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
                defaultValue: new DateTime(2024, 3, 2, 19, 20, 41, 602, DateTimeKind.Utc).AddTicks(1625),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "e1d9eca5-7a04-4df3-8dac-218dc346e4b4",
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
                defaultValue: "338b8459-1ee4-4e67-bee1-77ab924516fc",
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
                defaultValue: "87f3df1f-fd2d-4a13-b071-a9a483410feb",
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
                defaultValue: new DateTime(2024, 3, 2, 19, 20, 41, 601, DateTimeKind.Utc).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 0, 26, 813, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "9c394084-537c-4d87-96d9-5f0047585970",
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
                defaultValue: "2bb6f915-5225-404f-8e33-19968796eb25",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "bc51266a-884a-41c4-b6fc-dd5221114cbc")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
