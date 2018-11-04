using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Cadastra Nomes!");
            Console.WriteLine("Quantos nomes deseja cadastrar?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            string[] nomes = new string[quantidade];

            foreach (int i in Enumerable.Range(0, quantidade))
            {
                Console.WriteLine($"Digite o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine($"{quantidade} nomes cadastrados!");
            Console.Clear();

            Console.WriteLine("Deseja exibir os nomes cadastrados? (s/n)");
            string resposta = Console.ReadLine().ToUpper();
            Console.Clear();

            if (resposta.Equals("S"))
            {
                ExibeNomes(nomes);
            }

            Console.WriteLine($"{Environment.NewLine}Obrigado por usar o Cadastra Nomes!");
            Console.Read();
        }

        public static void ExibeNomes(string[] nomes)
        {
            Console.Write("Nomes: ");

            int i = 0;
            foreach (string nome in nomes)
            {
                i++;
                string auxiliar = "";

                if (i != nomes.Length)
                {
                    auxiliar = ", ";
                }
                else
                {
                    auxiliar = ".\n";
                }

                Console.Write($"{nome}{auxiliar}");
            }
        }
    }
}
