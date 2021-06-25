using System.Collections.Generic;
using Projeto_Produtos.Classes;

namespace Projeto_Produtos.Interfaces
{
    public interface IProduto
    {
         string Cadastrar(Produto produtoCadastar, List<Marca> ListarMarcas, int produtoid);
         string Deletar(Produto produtoDelete);
         void Listar();

    }
}