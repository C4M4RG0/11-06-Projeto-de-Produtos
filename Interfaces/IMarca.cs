using Projeto_Produtos.Classes;

namespace Projeto_Produtos.Interfaces
{
    public interface IMarca
    {
         string Cadastrar(Marca marcaCadastrar);
         string Deletar(Marca marcaDeletar);
         void Listar();
    }
}