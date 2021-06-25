using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;

namespace Projeto_Produtos.Classes
{
    public class Marca : IMarca
    {
        public int codigo { get; set; }
        public string nomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> ListarMarcas = new List<Marca>();

        public Marca() { }
        public Marca(int marcaId)
        {
            codigo = marcaId;
            Console.WriteLine(@"
______________________________
||                          ||
||        Qual o nome       ||
||         da marca?        ||
||__________________________||
");
            nomeMarca = Console.ReadLine();
            DataCadastro = DateTime.Now;
        }

        public string Cadastrar(Marca marcaCadastrar)
        {
            ListarMarcas.Add(marcaCadastrar);
            return @"
______________________________
||                          ||
||     Marca cadastrada     ||
||       com sucesso!       ||
||__________________________||
";
        }

        public string Deletar(Marca marcaDeletar)
        {
            ListarMarcas.Remove(marcaDeletar);
            return @"
______________________________
||                          ||
||      Marca deletada      ||
||       com sucesso!       ||
||__________________________||
";
        }

        public void Listar()
        {
            if (ListarMarcas.Count <= 0)
            {
                Console.WriteLine(@"
______________________________
||                          ||
||       Lista Vázia!       ||
||__________________________||
");
            }
            else
            {
                foreach (Marca item in ListarMarcas)
                {
                    Console.WriteLine($@"
______________________________
||                          ||
||    Marca: {item.nomeMarca}
||    Código: {item.codigo}
||    Data de cadastro: {item.DataCadastro}
||__________________________||
");
                }

            }
        }
        public List<Marca> ListarExistentes()
        {
            return ListarMarcas;
        }

    }
}