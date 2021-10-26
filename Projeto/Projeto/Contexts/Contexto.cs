using Projeto.Models;
using System.Data.Entity;

namespace Projeto.Contexts
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Asp_Net_MVC_5") {}

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}