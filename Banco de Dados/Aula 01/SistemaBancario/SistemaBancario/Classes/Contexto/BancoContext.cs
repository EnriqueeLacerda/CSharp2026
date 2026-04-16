using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contexto
{
    internal class BancoContext : DbContext
    {
        //propriedade
        /// <summary>
        /// Representa a tabela de contas bancarias no 
        /// banco de dados
        /// 
        /// DbSet permite realizar operações CRUD
        /// </summary>
        public DbSet<Banco> contas {  get; set; }

        // metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use the standard LocalDB instance name and include MultipleActiveResultSets
            optionsBuilder.UseSqlite("Data Source=BancoDB.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity=>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NumeroConta).IsRequired();
                entity.Property(e=>e.Titular).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");
            }
             );
        }
    }

}
