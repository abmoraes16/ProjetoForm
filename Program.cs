using System;

namespace ProjetoForm
{

    class Program
    {
        static void Main(string[] args)
        {
            string Nome=CadastroNome();
            string Genero=CadastroGenero();
            string RG=CadastroRG();
            string CPF=CadastroCPF();
        }
        static string CadastroNome(){
            string nome;

            nome = Console.ReadLine();
            
            return nome;
        }

        static string CadastroGenero()
        {
            string X;
            Console.WriteLine("Digite seu Gênero: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroRG()
        {
            string X;
            Console.WriteLine("Digite seu RG: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroCPF()
        {
            string X;
            Console.WriteLine("Digite seu CPF: ");
            X=Console.ReadLine();
            return X;
        }
    }
}
