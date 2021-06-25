using System.Collections.Generic;
using Projeto_Produtos.Interfaces;
using System;

namespace Projeto_Produtos.Classes
{
    public class Usuario : IUsuario
    {

        public int codigo { get; set; }
        public string nomeUser { get; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime dataCadastro { get; set; }

        List<Usuario> Listausers = new List<Usuario>();

        public Usuario(int userId)
        {
            codigo = userId;
            Console.WriteLine(@"
______________________________
||                          ||
||       Qual o nome        ||
||       do usuário?        ||
||__________________________||
");
            nomeUser = Console.ReadLine();
            Console.WriteLine(@"
______________________________
||                          ||
||       Qual o e-mail      ||
||        do usuário?       ||
||__________________________||
");
            email = Console.ReadLine();
            Console.WriteLine(@"
______________________________
||                          ||
||       Qual a senha       ||
||        do usuário?       ||
||__________________________||
");
            senha = Console.ReadLine();

            dataCadastro = DateTime.Now;
            userId++;

        }
        public string Cadastrar(Usuario userCadastro)
        {
            Listausers.Add(userCadastro);
            return @"
______________________________
||                          ||
||    PUsuário cadastrado   ||
||       com sucesso!       ||
||__________________________||
";
        }

        public string Deletar(Usuario userDelete)
        {
            Listausers.Remove(userDelete);
            return @"
______________________________
||                          ||
||     Usuário deletado     ||
||       com sucesso!       ||
||__________________________||
";

        }
    }
}