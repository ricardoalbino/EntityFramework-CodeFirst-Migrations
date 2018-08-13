using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Categoria categoria { get; set; }


    }
}
