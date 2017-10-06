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
<<<<<<< HEAD
            string Endereco=CadastroEndereco();
=======
            string EstadoCivil=CadastroEstadoCivil();
            string Profissao=CadastroProfissao();
>>>>>>> acfba9ae37dd889f8fc2a27fae83e343e0c0e744
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
<<<<<<< HEAD

        static string CadastroEndereco(){
            string endereco;
            Console.WriteLine("Digite seu endereco: ");
            endereco = Console.ReadLine();
            return endereco;
=======
        static string CadastroEstadoCivil()
        {
            string X;
            Console.WriteLine("Digite seu Estado Civil: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroProfissao()
        {
            string X;
            Console.WriteLine("Digite sua Profissão: ");
            X=Console.ReadLine();
            return X;
>>>>>>> acfba9ae37dd889f8fc2a27fae83e343e0c0e744
        }
    }
}
