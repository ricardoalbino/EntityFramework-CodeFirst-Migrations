using EntityFramework_CodeFirst_Migrations.EF_DBContext;
using EntityFramework_CodeFirst_Migrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations.Repository
{
    public class CategoriaRepository
    {
        public DBProduto dBProduto { get; set; }

        public void create(Categoria categoria)
        {
            dBProduto = new DBProduto();

            dBProduto.categoriasContext.Add(categoria);
            dBProduto.SaveChanges();

        }

        public IEnumerable<Categoria> Listar()
        {
            dBProduto = new DBProduto();
            return dBProduto.categoriasContext.ToList();
        }

        public void Update(Categoria categoria)
        {
            dBProduto = new DBProduto();

            Categoria categoriaUpdate = dBProduto.categoriasContext.Where(x => x.id == categoria.id).First();
            categoriaUpdate.descricao = categoria.descricao;
            dBProduto.SaveChanges();
        }

        public void delete(int id)
        {
            dBProduto = new DBProduto();

            Produto produtoExcluir = dBProduto.produtoContext.Where(x => x.id == id).First();
            dBProduto.produtoContext.Remove(produtoExcluir);
            dBProduto.SaveChanges();

        }
    }
}
