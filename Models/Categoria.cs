using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string descricao { get; set; }

        // Categoria possui uma lista de produtos
        public virtual IEnumerable<Produto> produtos { get; set; }
    }
}
