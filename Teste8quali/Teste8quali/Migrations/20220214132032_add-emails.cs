using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste8quali.Migrations
{
    public partial class addemails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "telefonecomercial",
                table: "Cliente",
                newName: "Telefonecomercial");

            migrationBuilder.RenameColumn(
                name: "telefonePessoal",
                table: "Cliente",
                newName: "TelefonePessoal");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "empresa",
                table: "Cliente",
                newName: "Empresa");

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Email_ClienteId",
                table: "Email",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.RenameColumn(
                name: "Telefonecomercial",
                table: "Cliente",
                newName: "telefonecomercial");

            migrationBuilder.RenameColumn(
                name: "TelefonePessoal",
                table: "Cliente",
                newName: "telefonePessoal");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Empresa",
                table: "Cliente",
                newName: "empresa");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
