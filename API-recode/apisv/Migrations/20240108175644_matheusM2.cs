using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apisv.Migrations
{
    /// <inheritdoc />
    public partial class matheusM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Usuario_price",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Usuario_url",
                table: "Usuarios",
                newName: "usuario_url");

            migrationBuilder.RenameColumn(
                name: "Usuario_name",
                table: "Usuarios",
                newName: "usuario_senha");

            migrationBuilder.RenameColumn(
                name: "Usuario_genre",
                table: "Usuarios",
                newName: "usuario_nome");

            migrationBuilder.AddColumn<string>(
                name: "usuario_cpf",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "usuario_data_nascimento",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "usuario_login",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "usuario_cpf", "usuario_login", "usuario_senha", "usuario_data_nascimento", "usuario_nome", "usuario_url" },
                values: new object[] { "111.222.333-44", "usuario1", "senha123", "1990-01-15", "Fulano da Silva", "" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "usuario_cpf", "usuario_login", "usuario_senha", "usuario_data_nascimento", "usuario_nome", "usuario_url" },
                values: new object[] { "222.333.444-55", "usuario2", "senha456", "1985-05-20", "Beltrano Oliveira", "" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "usuario_cpf", "usuario_login", "usuario_senha", "usuario_data_nascimento", "usuario_nome", "usuario_url" },
                values: new object[] { "333.444.555-66", "usuario3", "senha789", "1988-10-10", "Ciclano Pereira", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usuario_cpf",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "usuario_data_nascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "usuario_login",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "usuario_url",
                table: "Usuarios",
                newName: "Usuario_url");

            migrationBuilder.RenameColumn(
                name: "usuario_senha",
                table: "Usuarios",
                newName: "Usuario_name");

            migrationBuilder.RenameColumn(
                name: "usuario_nome",
                table: "Usuarios",
                newName: "Usuario_genre");

            migrationBuilder.AddColumn<decimal>(
                name: "Usuario_price",
                table: "Usuarios",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Usuario_genre", "Usuario_name", "Usuario_price", "Usuario_url" },
                values: new object[] { "RPG", "The Witcher 3", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Usuario_genre", "Usuario_name", "Usuario_price", "Usuario_url" },
                values: new object[] { "RPG", "The Witcher 2", 19.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Usuario_genre", "Usuario_name", "Usuario_price", "Usuario_url" },
                values: new object[] { "RPG", "The Witcher 1", 9.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "Usuario_genre", "Usuario_name", "Usuario_price", "Usuario_url" },
                values: new object[] { 4, "RPG", "The Witcher 3", 59.99m, "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png" });
        }
    }
}
