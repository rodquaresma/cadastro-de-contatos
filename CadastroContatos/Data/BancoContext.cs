using Microsoft.EntityFrameworkCore;
using CadastroContatos.Models;

namespace CadastroContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
