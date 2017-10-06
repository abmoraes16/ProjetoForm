using System;

namespace ProjetoForm
{

    class Program
    {
            static string Nome;
            static string Genero;
            static string RG;
            static string CPF;
            static string Endereco;
            static string EstadoCivil;
            static string Profissao;
            static string LocalNascimento;
            static string Idade;

        static void Main(string[] args)
        {
            Nome=CadastroNome();
            Genero=CadastroGenero();
            RG=CadastroRG();
            CPF=CadastroCPF();
            Endereco=CadastroEndereco();
            EstadoCivil=CadastroEstadoCivil();
            Profissao=CadastroProfissao();
            LocalNascimento=CadastroLocalNascimento();
            Idade=CadastroIdade();

            MostraDados();
        }
        
        static string CadastroNome(){
            string X;
            Console.Write("Digite seu Nome: ");
            X = Console.ReadLine();
            return X;
        }

        static string CadastroGenero()
        {
            string X;
            Console.Write("Digite seu Gênero: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroRG()
        {
            string X;
            Console.Write("Digite seu RG: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroCPF()
        {
            string X;
            Console.Write("Digite seu CPF: ");
            X=Console.ReadLine();
            return X;
        }

        static string CadastroEndereco(){
            string X;
            Console.Write("Digite seu endereco: ");
            X = Console.ReadLine();
            return X;
        }

        static string CadastroEstadoCivil()
        {
            string X;
            Console.Write("Digite seu Estado Civil: ");
            X=Console.ReadLine();
            return X;
        }
        static string CadastroProfissao()
        {
            string X;
            Console.Write("Digite sua Profissão: ");
            X=Console.ReadLine();
            return X;
        }

        static string CadastroLocalNascimento()
        {
            string X;
            Console.Write("Digite seu Local de Nascimento: ");
            X=Console.ReadLine();
            return X;
        }

        static string CadastroIdade()
        {
            string X;
            Console.Write("Digite sua Idade: ");
            X=Console.ReadLine();
            return X;
        }

        static void MostraDados()
        {
            Console.WriteLine("\n\nRESULTADO:\n");
            Console.WriteLine("Nome: "+Nome);
            Console.WriteLine("Nome: "+Genero);
            Console.WriteLine("Nome: "+RG);
            Console.WriteLine("Nome: "+CPF);
            Console.WriteLine("Nome: "+Endereco);
            Console.WriteLine("Nome: "+EstadoCivil);
            Console.WriteLine("Nome: "+Profissao);
            Console.WriteLine("Nome: "+LocalNascimento);
            Console.WriteLine("Nome: "+Idade);
        }
    }
}
