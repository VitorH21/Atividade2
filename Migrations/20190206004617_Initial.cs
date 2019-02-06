using Microsoft.EntityFrameworkCore.Migrations;

namespace Atividade2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencias_Bancos_BancoIdBanco",
                table: "Agencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaIdAgencia",
                table: "ContasCorrentes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContasPoupanca_Agencias_AgenciaIdAgencia",
                table: "ContasPoupanca");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Agencias_AgenciaIdAgencia",
                table: "Solicitacoes");

            migrationBuilder.RenameColumn(
                name: "AgenciaIdAgencia",
                table: "Solicitacoes",
                newName: "AgenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacoes_AgenciaIdAgencia",
                table: "Solicitacoes",
                newName: "IX_Solicitacoes_AgenciaId");

            migrationBuilder.RenameColumn(
                name: "AgenciaIdAgencia",
                table: "ContasPoupanca",
                newName: "AgenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_ContasPoupanca_AgenciaIdAgencia",
                table: "ContasPoupanca",
                newName: "IX_ContasPoupanca_AgenciaId");

            migrationBuilder.RenameColumn(
                name: "AgenciaIdAgencia",
                table: "ContasCorrentes",
                newName: "AgenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_ContasCorrentes_AgenciaIdAgencia",
                table: "ContasCorrentes",
                newName: "IX_ContasCorrentes_AgenciaId");

            migrationBuilder.RenameColumn(
                name: "IdBanco",
                table: "Bancos",
                newName: "BancoId");

            migrationBuilder.RenameColumn(
                name: "BancoIdBanco",
                table: "Agencias",
                newName: "BancoId");

            migrationBuilder.RenameColumn(
                name: "IdAgencia",
                table: "Agencias",
                newName: "AgenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Agencias_BancoIdBanco",
                table: "Agencias",
                newName: "IX_Agencias_BancoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencias_Bancos_BancoId",
                table: "Agencias",
                column: "BancoId",
                principalTable: "Bancos",
                principalColumn: "BancoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaId",
                table: "ContasCorrentes",
                column: "AgenciaId",
                principalTable: "Agencias",
                principalColumn: "AgenciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasPoupanca_Agencias_AgenciaId",
                table: "ContasPoupanca",
                column: "AgenciaId",
                principalTable: "Agencias",
                principalColumn: "AgenciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Agencias_AgenciaId",
                table: "Solicitacoes",
                column: "AgenciaId",
                principalTable: "Agencias",
                principalColumn: "AgenciaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencias_Bancos_BancoId",
                table: "Agencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaId",
                table: "ContasCorrentes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContasPoupanca_Agencias_AgenciaId",
                table: "ContasPoupanca");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Agencias_AgenciaId",
                table: "Solicitacoes");

            migrationBuilder.RenameColumn(
                name: "AgenciaId",
                table: "Solicitacoes",
                newName: "AgenciaIdAgencia");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacoes_AgenciaId",
                table: "Solicitacoes",
                newName: "IX_Solicitacoes_AgenciaIdAgencia");

            migrationBuilder.RenameColumn(
                name: "AgenciaId",
                table: "ContasPoupanca",
                newName: "AgenciaIdAgencia");

            migrationBuilder.RenameIndex(
                name: "IX_ContasPoupanca_AgenciaId",
                table: "ContasPoupanca",
                newName: "IX_ContasPoupanca_AgenciaIdAgencia");

            migrationBuilder.RenameColumn(
                name: "AgenciaId",
                table: "ContasCorrentes",
                newName: "AgenciaIdAgencia");

            migrationBuilder.RenameIndex(
                name: "IX_ContasCorrentes_AgenciaId",
                table: "ContasCorrentes",
                newName: "IX_ContasCorrentes_AgenciaIdAgencia");

            migrationBuilder.RenameColumn(
                name: "BancoId",
                table: "Bancos",
                newName: "IdBanco");

            migrationBuilder.RenameColumn(
                name: "BancoId",
                table: "Agencias",
                newName: "BancoIdBanco");

            migrationBuilder.RenameColumn(
                name: "AgenciaId",
                table: "Agencias",
                newName: "IdAgencia");

            migrationBuilder.RenameIndex(
                name: "IX_Agencias_BancoId",
                table: "Agencias",
                newName: "IX_Agencias_BancoIdBanco");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencias_Bancos_BancoIdBanco",
                table: "Agencias",
                column: "BancoIdBanco",
                principalTable: "Bancos",
                principalColumn: "IdBanco",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaIdAgencia",
                table: "ContasCorrentes",
                column: "AgenciaIdAgencia",
                principalTable: "Agencias",
                principalColumn: "IdAgencia",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasPoupanca_Agencias_AgenciaIdAgencia",
                table: "ContasPoupanca",
                column: "AgenciaIdAgencia",
                principalTable: "Agencias",
                principalColumn: "IdAgencia",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Agencias_AgenciaIdAgencia",
                table: "Solicitacoes",
                column: "AgenciaIdAgencia",
                principalTable: "Agencias",
                principalColumn: "IdAgencia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
