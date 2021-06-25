using Projeto_Produtos.Classes;

namespace Projeto_Produtos.Interfaces
{
    public interface ILogin
    {
        string Logar(Usuario user);
        string Deslogar(Usuario user);
    }
}