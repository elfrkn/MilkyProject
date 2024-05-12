using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkyProject.DataAccessLayer.Migrations
{
    public partial class mig_delete_socialRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Employers_EmployerID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_EmployerID",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "EmployerID",
                table: "SocialMedias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerID",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_EmployerID",
                table: "SocialMedias",
                column: "EmployerID");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Employers_EmployerID",
                table: "SocialMedias",
                column: "EmployerID",
                principalTable: "Employers",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
