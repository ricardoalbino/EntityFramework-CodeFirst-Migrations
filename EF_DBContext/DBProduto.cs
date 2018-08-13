using EntityFramework_CodeFirst_Migrations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations.EF_DBContext
{
    public class DBProduto : DbContext
    {
        // Gerar Tabelas no Banco de Dados
        public DbSet<Produto> produtoContext  { get; set; }
        public DbSet<Categoria> categoriasContext { get; set; }
    }
}
