namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Harry Potter e a Pedra Filosofal",
                    Description = "Harry Potter é uma série de sete romances de fantasia escrita pela autora britânica J. K. Rowling. A série narra as aventuras de um jovem chamado Harry James Potter, que descobre aos 11 anos de idade que é um bruxo ao ser convidado para estudar na Escola de Magia e Bruxaria de Hogwarts.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/c/c1/Capa_HP1.jpg",
                    Price = 19.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Description = "O livro se envolve em torno da lenda de uma câmara secreta localizada na Escola de Magia e Bruxaria de Hogwarts, na qual abriga um monstro que matará a todos os bruxos que não provém de famílias mágicas. Diversos alunos aparecem petrificados e Harry Potter, além de ser apontado como o maior suspeito, tenta desvendar e resolver o mistério junto de seus melhores amigos, Rony Weasley e Hermione Granger.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/9/97/Capa_HP2.jpg/230px-Capa_HP2.jpg",
                    Price = 29.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Harry Potter e o Prisioneiro de Azkaban",
                    Description = "O livro conta sobre o terceiro ano de Harry Potter na Escola de Magia e Bruxaria de Hogwarts. Sem a aparição de Voldemort, a trama apresenta um novo perigo para o personagem principal: Sirius Black, que teria assassinado treze pessoas com um único feitiço, fugiu da prisão de Azkaban e estaria agora o perseguindo para matá-lo.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/e/eb/Capa_HP3.jpg/230px-Capa_HP3.jpg",
                    Price = 39.99m
                }
            );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}