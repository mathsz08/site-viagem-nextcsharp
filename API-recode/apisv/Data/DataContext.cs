
using Microsoft.EntityFrameworkCore;
using Usuarios.Model;

namespace Usuarios.Data{
    public class DataContext : DbContext
  {

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }



    public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
               new Usuario { Id = 1, Login = "usuario1", Senha = "senha123", Cpf = "111.222.333-44", nome = "Fulano da Silva", data_nascimento = "1990-01-15", usuarioURL = "" },
                new Usuario { Id = 2, Login = "usuario2", Senha = "senha456", Cpf = "222.333.444-55", nome = "Beltrano Oliveira", data_nascimento = "1985-05-20", usuarioURL = "" },
                new Usuario { Id = 3, Login = "usuario3", Senha = "senha789", Cpf = "333.444.555-66", nome = "Ciclano Pereira", data_nascimento = "1988-10-10", usuarioURL = "" }
            );
        }



    }
}