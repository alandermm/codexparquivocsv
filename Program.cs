using System;
using System.IO;
namespace codexparquivocsv
{
    class Program
    {
        static void Main(string[] args) {
            
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            string idade = Console.ReadLine();
            

            StreamWriter sw = new StreamWriter("Arquivo.csv", true);
            sw.WriteLine(nome + ";" + idade);
            sw.Close();
        }
    }
}