using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

        /*
         * Após add as classes de modelo, adiciona o DBSet para o modelo e executa o comando para adicionar outra Migration
         * Add-Migration OtherEntities
         * 
         * Para atualizar o Banco de dados:
         * Update-Database
         */
    }
}
