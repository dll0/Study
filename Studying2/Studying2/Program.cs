using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = false;
            string password = "";
            string userName = "";

            while (!isRegistered)
            {
                Console.WriteLine("Bem-vindo ao sistema, você ainda não está cadastrado! Deseja se registrar? (s/n)");
                bool evaluateInput = Console.ReadLine().ToUpper().Equals("S");

                if (evaluateInput)
                {
                    Console.WriteLine("Prosseguiremos com o seu cadastro.");
                }
                else
                {
                    Console.WriteLine("Obrigado por usar o sistema, saindo...");
                    break;
                }

                int auxUserName = 0;
                while (userName.Length < 1 || userName.Length > 8)
                {
                    if (auxUserName == 0)
                    {
                        Console.WriteLine("Digite seu nome de usuário: ");
                        auxUserName++;
                    }
                    else
                    {
                        Console.WriteLine("Nome de usuário deve possuir entre 1 à 8 caracteres, tente novamente");
                    }

                    userName = Console.ReadLine();
                }

                int auxPassword = 0;
                while (password.Length < 1 || password.Length > 12)
                {
                    if (auxPassword == 0)
                    {
                        Console.WriteLine("Digite sua nova senha: ");
                        auxPassword++;
                    }
                    else
                    {
                        Console.WriteLine("Senha deve possuir entre 1 à 12 caracteres, tente novamente");
                    }

                    password = Console.ReadLine();
                }

                Console.WriteLine($"{Environment.NewLine}****DEBUG****{Environment.NewLine}" +
                    $"Usuário: {userName}{Environment.NewLine}" +
                    $"Senha: {password}");

                if (!password.Equals("")
                    && !userName.Equals(""))
                {
                    isRegistered = true;
                    Console.Clear();
                    Console.WriteLine("Prosseguindo para a área de login...");
                }
            }

            bool isLogged = false;

            while (!isLogged && isRegistered)
            {
                Console.WriteLine("Insira seu nome de usuário: ");
                string userNameInput = Console.ReadLine();
                bool verifyIntegrityUserName = userNameInput.ToUpper().Equals(userName.ToUpper());

                Console.WriteLine("Insira sua senha:");
                string passwordInput = Console.ReadLine();
                bool verifyIntegrityPassword = passwordInput.Equals(password);

                if (!verifyIntegrityUserName && !verifyIntegrityPassword)
                { 
                    Console.Clear();
                    Console.WriteLine("Nome de usuário e senha errados, tente novamente:");
                }
                else if (!verifyIntegrityPassword) {
                    Console.Clear();
                    Console.WriteLine("Senha errada, tente novamente:");
                }
                else if (!verifyIntegrityUserName)
                {
                    Console.Clear();
                    Console.WriteLine("Nome de usuário inválido, tente novamente:");
                }
                else
                {
                    Console.Clear();
                    isLogged = true;
                    Console.WriteLine($"Olá, {userName}. Você logou com sucesso no sistema!");
                }
            }

            Console.ReadKey();
        }
    }
}
