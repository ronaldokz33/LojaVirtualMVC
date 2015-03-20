using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualMVC.Repositorio
{
    public class EFDBContext : DbContext
    {
        public DbSet<Entidade.Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            modelBuilder.Entity<Entidade.Produto>().ToTable("Produtos");
        }
    }
}
