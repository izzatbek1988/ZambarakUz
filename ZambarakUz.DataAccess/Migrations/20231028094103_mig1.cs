using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZambarakUz.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTS_GROUPS",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MAX_SUM_CREDIT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PRICE_UID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_SUPPLIER = table.Column<bool>(type: "bit", nullable: false),
                    IS_NON_USE_BONUS = table.Column<bool>(type: "bit", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTS_GROUPS", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "USERS_GROUPS",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_SUPER = table.Column<bool>(type: "bit", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS_GROUPS", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTS",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATE_ADD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GROUP_UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BIRTHDAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BARCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTS", x => x.UID);
                    table.ForeignKey(
                        name: "FK_CLIENTS_CLIENTS_GROUPS_GROUP_UID",
                        column: x => x.GROUP_UID,
                        principalTable: "CLIENTS_GROUPS",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GROUP_UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CLIENT_UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ALIAS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LOGIN_FOR_KKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD_FOR_KKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BARCODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FONT_SIZE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATE_IN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_OUT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_KICKED = table.Column<bool>(type: "bit", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: true),
                    SECTION_UID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.UID);
                    table.ForeignKey(
                        name: "FK_USERS_CLIENTS_CLIENT_UID",
                        column: x => x.CLIENT_UID,
                        principalTable: "CLIENTS",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USERS_USERS_GROUPS_GROUP_UID",
                        column: x => x.GROUP_UID,
                        principalTable: "USERS_GROUPS",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTS_GROUP_UID",
                table: "CLIENTS",
                column: "GROUP_UID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_CLIENT_UID",
                table: "USERS",
                column: "CLIENT_UID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_GROUP_UID",
                table: "USERS",
                column: "GROUP_UID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "CLIENTS");

            migrationBuilder.DropTable(
                name: "USERS_GROUPS");

            migrationBuilder.DropTable(
                name: "CLIENTS_GROUPS");
        }
    }
}
