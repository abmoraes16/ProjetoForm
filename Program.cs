using System;

namespace ProjetoForm
{

    class Program
    {
        static void Main(string[] args)
        {
            string Genero=CadastroGenero();
            double RG=CadastroRG();
        }
        static string CadastroGenero()
        {
            string X;
            Console.WriteLine("Digite seu Gênero: ");
            X=Console.ReadLine();
            return X;
        }
        static double CadastroRG()
        {
            double X;
            Console.WriteLine("Digite seu Gênero: ");
            X=double.Parse(Console.ReadLine());
            return X;
        }
    }
}
