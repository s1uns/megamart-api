using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class IdentityExtension : Migration
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
                defaultValue: "a46870ce-7283-4ee3-a3fc-fa8aa9717007",
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
                defaultValue: new DateTime(2024, 2, 29, 19, 27, 12, 394, DateTimeKind.Utc).AddTicks(373),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 90, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "84093755-0fb0-470a-8ecf-9d5d8b0e98b2",
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
                defaultValue: "ab305d1d-ec25-494d-8fb8-ef9c9c77f262",
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
                defaultValue: "0dba3dc8-75a1-4e1a-a5a6-13332eab6154",
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
                defaultValue: "760821fd-9c9f-4594-8757-8fd7d361b301",
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
                defaultValue: "19b9ff83-5019-4275-8006-8f870699b771",
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
                defaultValue: new DateTime(2024, 2, 29, 19, 27, 12, 393, DateTimeKind.Utc).AddTicks(828),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 12, 17, 54, 57, 89, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "a21ab08d-b81b-48a1-ad67-30f06aab353f",
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
                defaultValue: "95abf3d5-08e8-45d7-bfdb-1df39b39ede3",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "2b0a10d0-b2ba-451d-8262-0df056e6d172")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                oldDefaultValue: "a46870ce-7283-4ee3-a3fc-fa8aa9717007")
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
                oldDefaultValue: new DateTime(2024, 2, 29, 19, 27, 12, 394, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "f2ca8fe8-433d-44d7-968c-61756de4f55c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "84093755-0fb0-470a-8ecf-9d5d8b0e98b2")
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
                oldDefaultValue: "ab305d1d-ec25-494d-8fb8-ef9c9c77f262")
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
                oldDefaultValue: "0dba3dc8-75a1-4e1a-a5a6-13332eab6154")
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
                oldDefaultValue: "760821fd-9c9f-4594-8757-8fd7d361b301")
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
                oldDefaultValue: "19b9ff83-5019-4275-8006-8f870699b771")
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
                oldDefaultValue: new DateTime(2024, 2, 29, 19, 27, 12, 393, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Customers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "942899ed-639f-4e37-8157-72608bc58d7c",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldDefaultValue: "a21ab08d-b81b-48a1-ad67-30f06aab353f")
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
                oldDefaultValue: "95abf3d5-08e8-45d7-bfdb-1df39b39ede3")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
