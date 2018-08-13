using EntityFramework_CodeFirst_Migrations.EF_DBContext;
using EntityFramework_CodeFirst_Migrations.Models;
using EntityFramework_CodeFirst_Migrations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Migrations
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriaRepository categoriaRepository = new CategoriaRepository();
            ProdutoRepository produtoRepository = new ProdutoRepository();

            
             Categoria categoria = new Categoria();
             categoria.id = 2;
             categoria.descricao = "Cesta Basica";

             categoriaRepository.Update(categoria);
       
             

        

            Console.WriteLine("Tabela Produto");
            var listaProduto = produtoRepository.Listar();
            foreach (var lista in listaProduto)
            {
                Console.WriteLine("{0}-{1}-{2}", lista.id.ToString(), lista.nome, lista.categoria.descricao);
            }
            Console.ReadKey();


            /////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Tabela Categoria");
            var listaCategoria = categoriaRepository.Listar();
            foreach (var lista in listaCategoria)
            {
                Console.WriteLine("{0}-{1}" ,lista.id.ToString(), lista.descricao);
            }
            Console.ReadKey();
        }

    }

}
