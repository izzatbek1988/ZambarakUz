using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZambarakUz.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USERS_CLIENTS_CLIENT_UID",
                table: "USERS");

            migrationBuilder.DropForeignKey(
                name: "FK_USERS_USERS_GROUPS_GROUP_UID",
                table: "USERS");

            migrationBuilder.DropIndex(
                name: "IX_USERS_CLIENT_UID",
                table: "USERS");

            migrationBuilder.DropIndex(
                name: "IX_USERS_GROUP_UID",
                table: "USERS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_USERS_CLIENT_UID",
                table: "USERS",
                column: "CLIENT_UID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_GROUP_UID",
                table: "USERS",
                column: "GROUP_UID");

            migrationBuilder.AddForeignKey(
                name: "FK_USERS_CLIENTS_CLIENT_UID",
                table: "USERS",
                column: "CLIENT_UID",
                principalTable: "CLIENTS",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USERS_USERS_GROUPS_GROUP_UID",
                table: "USERS",
                column: "GROUP_UID",
                principalTable: "USERS_GROUPS",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
