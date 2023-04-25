using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Urbanyo.API.Migrations
{
    /// <inheritdoc />
    public partial class ProjectDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "States",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionConstructionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NameProj = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "questionConstructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    Question1 = table.Column<int>(type: "int", nullable: false),
                    Question2 = table.Column<int>(type: "int", nullable: false),
                    Question3 = table.Column<int>(type: "int", nullable: false),
                    Question4 = table.Column<int>(type: "int", nullable: false),
                    Question5 = table.Column<int>(type: "int", nullable: false),
                    Question6 = table.Column<int>(type: "int", nullable: false),
                    Question7 = table.Column<int>(type: "int", nullable: false),
                    Question8 = table.Column<int>(type: "int", nullable: false),
                    txtAdicional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionConstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stateProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stateProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "projectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    QuestionConstructionId = table.Column<int>(type: "int", nullable: true),
                    StateProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projectTypes_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_projectTypes_questionConstructions_QuestionConstructionId",
                        column: x => x.QuestionConstructionId,
                        principalTable: "questionConstructions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_projectTypes_stateProjects_StateProjectId",
                        column: x => x.StateProjectId,
                        principalTable: "stateProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_States_ProjectId",
                table: "States",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProjectId",
                table: "Cities",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_QuestionConstructionId",
                table: "AspNetUsers",
                column: "QuestionConstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId_UserId_StateId_CityId",
                table: "Projects",
                columns: new[] { "ProjectTypeId", "UserId", "StateId", "CityId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_projectTypes_ProjectId",
                table: "projectTypes",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_projectTypes_QuestionConstructionId",
                table: "projectTypes",
                column: "QuestionConstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_projectTypes_StateProjectId",
                table: "projectTypes",
                column: "StateProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_stateProjects_ProjectTypeId",
                table: "stateProjects",
                column: "ProjectTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_questionConstructions_QuestionConstructionId",
                table: "AspNetUsers",
                column: "QuestionConstructionId",
                principalTable: "questionConstructions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Projects_ProjectId",
                table: "Cities",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Projects_ProjectId",
                table: "States",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_questionConstructions_QuestionConstructionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Projects_ProjectId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Projects_ProjectId",
                table: "States");

            migrationBuilder.DropTable(
                name: "projectTypes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "questionConstructions");

            migrationBuilder.DropTable(
                name: "stateProjects");

            migrationBuilder.DropIndex(
                name: "IX_States_ProjectId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ProjectId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_QuestionConstructionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "QuestionConstructionId",
                table: "AspNetUsers");
        }
    }
}
