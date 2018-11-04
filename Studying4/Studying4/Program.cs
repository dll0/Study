using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de cadastro de notas");
            Console.WriteLine("Querido professor, por favor, insira seu nome:");
            string nomeProfessor = Console.ReadLine();

            Console.WriteLine($"Bem-vindo, Profº. {nomeProfessor}{Environment.NewLine}" +
                $"Prossiga para o cadastro de notas! {Environment.NewLine}{Environment.NewLine}" +
                $"Insira as notas, de 0 a 20. Quando desejar calcular a média do aluno, digite '-1' e após, " +
                $"pressione 'ENTER'.");

            string notaInput = "0";
            double nota = 0;
            double totalizador = 0;
            int contadorLoop = 0;

            while(nota != -1) {
                notaInput = Console.ReadLine();
                bool converteu = double.TryParse(notaInput, out nota);

                if (!converteu || (nota < 0 || nota >= 20) && nota != -1) {
                    Console.WriteLine("Por favor, insira um número entre 0 e 20 ou -1 para sair do sistema");
                    continue;
                } else if (nota != -1) {
                    totalizador += nota;
                    Console.WriteLine($"{contadorLoop + 1}ª nota adicionado, seu valor é {nota}");
                    contadorLoop++;
                    continue;
                } else if (nota == -1) {
                    Console.Clear();
                    Console.WriteLine("-1 recebido, encerrando cadastro de notas.");
                    break;
                }
            }

            double media = totalizador / contadorLoop;
            Console.WriteLine($"{contadorLoop} notas cadastradas, média final: {media}");

            Console.Read();
        }
    }
}
