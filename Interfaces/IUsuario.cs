using Projeto_Produtos.Classes;

namespace Projeto_Produtos.Interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario userCadastro);
        string Deletar(Usuario userDelete);
    }
}