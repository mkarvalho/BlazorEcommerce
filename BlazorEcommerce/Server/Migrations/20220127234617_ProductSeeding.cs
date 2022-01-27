using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Harry Potter é uma série de sete romances de fantasia escrita pela autora britânica J. K. Rowling. A série narra as aventuras de um jovem chamado Harry James Potter, que descobre aos 11 anos de idade que é um bruxo ao ser convidado para estudar na Escola de Magia e Bruxaria de Hogwarts.", "https://upload.wikimedia.org/wikipedia/pt/c/c1/Capa_HP1.jpg", 19.99m, "Harry Potter e a Pedra Filosofal" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "O livro se envolve em torno da lenda de uma câmara secreta localizada na Escola de Magia e Bruxaria de Hogwarts, na qual abriga um monstro que matará a todos os bruxos que não provém de famílias mágicas. Diversos alunos aparecem petrificados e Harry Potter, além de ser apontado como o maior suspeito, tenta desvendar e resolver o mistério junto de seus melhores amigos, Rony Weasley e Hermione Granger.", "https://upload.wikimedia.org/wikipedia/pt/thumb/9/97/Capa_HP2.jpg/230px-Capa_HP2.jpg", 29.99m, "Harry Potter and the Chamber of Secrets" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "O livro conta sobre o terceiro ano de Harry Potter na Escola de Magia e Bruxaria de Hogwarts. Sem a aparição de Voldemort, a trama apresenta um novo perigo para o personagem principal: Sirius Black, que teria assassinado treze pessoas com um único feitiço, fugiu da prisão de Azkaban e estaria agora o perseguindo para matá-lo.", "https://upload.wikimedia.org/wikipedia/pt/thumb/e/eb/Capa_HP3.jpg/230px-Capa_HP3.jpg", 39.99m, "Harry Potter e o Prisioneiro de Azkaban" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
