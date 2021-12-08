using CrudMvcEndereco.Models.Entidade;
using Microsoft.EntityFrameworkCore;

namespace CrudMvcEndereco.Models.Contexto
{


    public class ContextoBancoDeDados : DbContext
    {
        public ContextoBancoDeDados(DbContextOptions<ContextoBancoDeDados> option) : base(option)
        {
            Database.EnsureCreated();/*Vai verificar se o banco existe, se não existir ele vai seguir o contexto da entidade, se existir ele atualiza as colunas*/
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pais> Paises { get; set; }
    }
}
