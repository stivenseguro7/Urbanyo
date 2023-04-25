using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urbanyo.API.Migrations
{
    /// <inheritdoc />
    public partial class Projectdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_questionConstructions_QuestionConstructionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_projectTypes_Projects_ProjectId",
                table: "projectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_projectTypes_questionConstructions_QuestionConstructionId",
                table: "projectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_projectTypes_stateProjects_StateProjectId",
                table: "projectTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stateProjects",
                table: "stateProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_questionConstructions",
                table: "questionConstructions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projectTypes",
                table: "projectTypes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_QuestionConstructionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "QuestionConstructionId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "stateProjects",
                newName: "StateProjects");

            migrationBuilder.RenameTable(
                name: "questionConstructions",
                newName: "QuestionConstructions");

            migrationBuilder.RenameTable(
                name: "projectTypes",
                newName: "ProjectTypes");

            migrationBuilder.RenameIndex(
                name: "IX_stateProjects_ProjectTypeId",
                table: "StateProjects",
                newName: "IX_StateProjects_ProjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_projectTypes_StateProjectId",
                table: "ProjectTypes",
                newName: "IX_ProjectTypes_StateProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_projectTypes_QuestionConstructionId",
                table: "ProjectTypes",
                newName: "IX_ProjectTypes_QuestionConstructionId");

            migrationBuilder.RenameIndex(
                name: "IX_projectTypes_ProjectId",
                table: "ProjectTypes",
                newName: "IX_ProjectTypes_ProjectId");

            migrationBuilder.AddColumn<int>(
                name: "QuestionLegalizationId",
                table: "ProjectTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionReshuffleId",
                table: "ProjectTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateProjects",
                table: "StateProjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionConstructions",
                table: "QuestionConstructions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTypes",
                table: "ProjectTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "QuestionLegalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionLegalizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionReshuffles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    Question1 = table.Column<bool>(type: "bit", nullable: false),
                    ParcialReshuffle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionReshuffles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionConstructions_ProjectTypeId",
                table: "QuestionConstructions",
                column: "ProjectTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_QuestionLegalizationId",
                table: "ProjectTypes",
                column: "QuestionLegalizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_QuestionReshuffleId",
                table: "ProjectTypes",
                column: "QuestionReshuffleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionLegalizations_ProjectTypeId",
                table: "QuestionLegalizations",
                column: "ProjectTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionReshuffles_ProjectTypeId",
                table: "QuestionReshuffles",
                column: "ProjectTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTypes_Projects_ProjectId",
                table: "ProjectTypes",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTypes_QuestionConstructions_QuestionConstructionId",
                table: "ProjectTypes",
                column: "QuestionConstructionId",
                principalTable: "QuestionConstructions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTypes_QuestionLegalizations_QuestionLegalizationId",
                table: "ProjectTypes",
                column: "QuestionLegalizationId",
                principalTable: "QuestionLegalizations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTypes_QuestionReshuffles_QuestionReshuffleId",
                table: "ProjectTypes",
                column: "QuestionReshuffleId",
                principalTable: "QuestionReshuffles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTypes_StateProjects_StateProjectId",
                table: "ProjectTypes",
                column: "StateProjectId",
                principalTable: "StateProjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTypes_Projects_ProjectId",
                table: "ProjectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTypes_QuestionConstructions_QuestionConstructionId",
                table: "ProjectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTypes_QuestionLegalizations_QuestionLegalizationId",
                table: "ProjectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTypes_QuestionReshuffles_QuestionReshuffleId",
                table: "ProjectTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTypes_StateProjects_StateProjectId",
                table: "ProjectTypes");

            migrationBuilder.DropTable(
                name: "QuestionLegalizations");

            migrationBuilder.DropTable(
                name: "QuestionReshuffles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateProjects",
                table: "StateProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionConstructions",
                table: "QuestionConstructions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionConstructions_ProjectTypeId",
                table: "QuestionConstructions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTypes",
                table: "ProjectTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTypes_QuestionLegalizationId",
                table: "ProjectTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTypes_QuestionReshuffleId",
                table: "ProjectTypes");

            migrationBuilder.DropColumn(
                name: "QuestionLegalizationId",
                table: "ProjectTypes");

            migrationBuilder.DropColumn(
                name: "QuestionReshuffleId",
                table: "ProjectTypes");

            migrationBuilder.RenameTable(
                name: "StateProjects",
                newName: "stateProjects");

            migrationBuilder.RenameTable(
                name: "QuestionConstructions",
                newName: "questionConstructions");

            migrationBuilder.RenameTable(
                name: "ProjectTypes",
                newName: "projectTypes");

            migrationBuilder.RenameIndex(
                name: "IX_StateProjects_ProjectTypeId",
                table: "stateProjects",
                newName: "IX_stateProjects_ProjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTypes_StateProjectId",
                table: "projectTypes",
                newName: "IX_projectTypes_StateProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTypes_QuestionConstructionId",
                table: "projectTypes",
                newName: "IX_projectTypes_QuestionConstructionId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTypes_ProjectId",
                table: "projectTypes",
                newName: "IX_projectTypes_ProjectId");

            migrationBuilder.AddColumn<int>(
                name: "QuestionConstructionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_stateProjects",
                table: "stateProjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questionConstructions",
                table: "questionConstructions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projectTypes",
                table: "projectTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_QuestionConstructionId",
                table: "AspNetUsers",
                column: "QuestionConstructionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_questionConstructions_QuestionConstructionId",
                table: "AspNetUsers",
                column: "QuestionConstructionId",
                principalTable: "questionConstructions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projectTypes_Projects_ProjectId",
                table: "projectTypes",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projectTypes_questionConstructions_QuestionConstructionId",
                table: "projectTypes",
                column: "QuestionConstructionId",
                principalTable: "questionConstructions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projectTypes_stateProjects_StateProjectId",
                table: "projectTypes",
                column: "StateProjectId",
                principalTable: "stateProjects",
                principalColumn: "Id");
        }
    }
}
