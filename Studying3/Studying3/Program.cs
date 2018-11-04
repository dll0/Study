using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying3
{
    class Program
    {
        public static int highscore = 4295;
        public static int oldHighscore;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string playerName = Console.ReadLine();

            int score = 0;
            bool isFirst = true;
            string ask;
            while(score <= 0)
            {
                if (isFirst)
                {
                    ask = "Digite sua pontuação:";
                    isFirst = false;
                }
                else
                {
                    ask = "Pontuação inválida, tente novamente:";
                }

                Console.WriteLine(ask);
                string inputScore = Console.ReadLine();
                int.TryParse(inputScore, out score);
            }

            Console.Clear();

            bool isHigh = isHighscore(score, playerName);

            //drawSymbol("*", 40, true);
            //drawSymbol("*", 16, false);
            //Console.Write("Debugger");
            //drawSymbol("*", 16, true);
            //drawSymbol("*", 40, true);

            //Console.WriteLine($"Nome: {playerName}{Environment.NewLine}" +
            //    $"Pontuação: {score}{Environment.NewLine}" +
            //    $"Pontuação mais alta: {highscore}{Environment.NewLine}" +
            //    $"É mais alta? {isHigh}");

            //drawSymbol("*", 40, true);

            string result;

            if (isHigh)
            {
                result = $"Parabéns {playerName}, você bateu o recorde de {oldHighscore}. Agora o recorde é igual a {highscore}!";
            }
            else
            {
                result = $"Que pena, {playerName}. Você não conseguiu bater o recorde de {highscore} por uma diferença de {highscore - score}.";
            }

            Console.WriteLine(result);

            Console.Read();
        }

        public static bool isHighscore (int score, string playerName)
        { 
            if (score > highscore)
            {
                oldHighscore = highscore;
                highscore = score;
                return true;
            } else
            {
                return false;
            }
        }

        public static void drawSymbol (string symbol, int quantity, bool breakLine)
        {
            foreach (int i in Enumerable.Range(0, quantity))
            {
                Console.Write(symbol);

                if(i+1 == quantity && breakLine)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}
