using EntityFramework_CodeFirst_Migrations.EF_DBContext;
using EntityFramework_CodeFirst_Migrations.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations.Repository
{
    class ProdutoRepository
    {
        public DBProduto dBProduto { get; set; }

        public  void create(Produto produto)
        {
            dBProduto = new DBProduto();

            //Busca a Categoria do produto p/ não duplicar o registro no banco
            produto.categoria = dBProduto.categoriasContext.ToList().Where(x => x.id == produto.categoria.id).FirstOrDefault();
            dBProduto.produtoContext.Add(produto);
            dBProduto.SaveChanges();
           
        }

        public IEnumerable<Produto> Listar()
        {
            dBProduto = new DBProduto();

            // Aqui e relacionado o Produto e Categoria atravez do Linq "using System.Data.Entity"
            return dBProduto.produtoContext.Include(x=>x.categoria).ToList();
        } 

        public void Update(Produto produto)
        {
            dBProduto = new DBProduto();

            Produto produtoUpdate = dBProduto.produtoContext.Where(x=> x.id == produto.id).First();
            produtoUpdate.nome = produto.nome;
            dBProduto.SaveChanges();
        }

        public void delete(int id)
        {
            dBProduto = new DBProduto();

            Produto produtoExcluir = dBProduto.produtoContext.Where(x=> x.id == id).First();
            dBProduto.produtoContext.Remove(produtoExcluir);
            dBProduto.SaveChanges();

        }
    }
}
