using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace localizaBaba.Web.Migrations
{
    public partial class trocandooguidporint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Babas",
                keyColumn: "Id",
                keyValue: new Guid("5f290abb-1d4e-4cc9-9b5b-e9d0fc675ee0"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("1544abf6-beb5-4928-93d2-96007a0915c5"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("121ff2ca-ae86-4921-a7b4-2334fdf613df"));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Babas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Babas",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { 1, "baba@baba.com", "Novo Baba", "123456", null });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { 1, "cliente@cliente.com", "Novo Cliente", "123456", null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { 1, "luiz@rkcomex.com", "Luiz", "123456", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Babas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Usuarios",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Clientes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Babas",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Babas",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("5f290abb-1d4e-4cc9-9b5b-e9d0fc675ee0"), "baba@baba.com", "Novo Baba", "123456", null });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("1544abf6-beb5-4928-93d2-96007a0915c5"), "cliente@cliente.com", "Novo Cliente", "123456", null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("121ff2ca-ae86-4921-a7b4-2334fdf613df"), "luiz@rkcomex.com", "Luiz", "123456", null });
        }
    }
}
