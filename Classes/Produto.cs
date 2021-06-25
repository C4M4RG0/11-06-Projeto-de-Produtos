using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;

namespace Projeto_Produtos.Classes
{
    public class Produto : IProduto
    {
        public int codigo { get; set; }
        public string nomeProduto { get; set; }
        public float preco { get; set; }
        public Marca marca { get; set; }
        public Usuario cadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Produto> ListarProdutos = new List<Produto>();

        public Produto() { }
        public Produto(int codigoId, Usuario user, List<Marca> ListarMarcas)
        {
            codigo = codigoId;
            Console.WriteLine(@"
______________________________
||                          ||
||      Digite o nome       || 
||       do produto:        ||
||__________________________||
");
            nomeProduto = Console.ReadLine();
            Console.WriteLine(@"\n
______________________________
||                          ||
||      Digite o preço      ||
||        do produto:       ||
||__________________________||
");
            preco = float.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;

            cadastradoPor = user;
            Console.WriteLine(@"
______________________________
||                          ||
||       Digite o nome      ||
||         da marca:        ||
||__________________________||
");
            string VMarca = Console.ReadLine();
            marca = ListarMarcas.Find(x => x.nomeMarca == VMarca);
        }


        public string Cadastrar(Produto produtoCadastrar, List<Marca> ListarMarcas, int produtoid)
        {
            if (ListarMarcas.Count > 0 && produtoCadastrar.marca != null)
            {
                ListarProdutos.Add(produtoCadastrar);
                return @"\n 
______________________________
||                          ||
||    Produto cadastrado    ||
||       com sucesso!       ||
||__________________________||
";
            }
            else if (ListarMarcas.Count <= 0)
            {
                return @"
______________________________
||                          ||
||      Não é possível      ||
||       cadastrar um       ||
||     produnto sem uma     ||
||     marca cadastrada     ||
||      primeiramente!      ||
||__________________________||
";
            }
            else
            {
                return "";
            }

        }

        public string Deletar(Produto produtoCadastrar)
        {
            ListarProdutos.Remove(produtoCadastrar);
            return @"\n 
______________________________
||                          ||
||     Produto deletado     ||
||       com sucesso!       ||
||__________________________||
";
        }

        public void Listar()
        {
            if (ListarProdutos.Count <= 0)
            {
                Console.WriteLine(@"
______________________________
||                          ||
||   A lista está vazia!    ||
||    Você não cadastrou    ||
||      nenhuma marca!      ||
||__________________________||
");

            }
            else
            {
                Console.WriteLine(@"\n 
______________________________
||                          ||
||   Produtos cadastrado    ||
||       com sucesso!       ||
||__________________________||
");
                foreach (Produto item in ListarProdutos)
                {
                    Console.WriteLine($@"
______________________________
||                          ||
||    Nome do produto: {item.nomeProduto}
||    Preço: {item.preco:C2}
||    Código: {item.codigo}
||    Data de cadastro: {item.DataCadastro}
||    Marca: {item.marca.nomeMarca}
||    Cadastrado por: {item.cadastradoPor.nomeUser}
||__________________________||
");
                }
            }
        }
        public List<Produto> ListarExistentes()
        {
            return ListarProdutos;
        }
    }
}