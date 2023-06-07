using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string admlogin;
            string admkey;
            string userlogin;
            string userkey;
            string usertext;
            string usertest;
            string userkeytest;

            Console.WriteLine("Bem vindo ao Conradito's Bank");
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Login");
            usertext = Console.ReadLine();

            if (usertext == "1")
            {
                Console.WriteLine("\nCrie um usuário:");
                userlogin = Console.ReadLine();
                Console.WriteLine("\nCrie uma senha:");
                userkey = Console.ReadLine();

                Console.WriteLine("\nAgora entre com o seu usuário:");
                usertest = Console.ReadLine();
                Console.WriteLine("\nAgora entre com a sua senha:");
                userkeytest = Console.ReadLine();

                if(userlogin == usertest)
                {
                    if(userkey == userkeytest)
                    {
                        Console.WriteLine("\nBem-vindo ao sistema");
                    }
                    else
                    {
                        Console.WriteLine("Você entrou com usuario ou senha invalidos");
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Você entrou com usuario ou senha invalidos");
                    Console.ReadLine();
                    Console.Clear();
                    Main(null);
                    return;
                }
                
            }

            if (usertext == "2")
            {
                Console.WriteLine("\nEntre com o seu usuário:");
                admlogin = Console.ReadLine();
                Console.WriteLine("\nEntre com a sua senha:");
                admkey = Console.ReadLine();

                if(admlogin == "miltom")
                {
                    if (admkey == "godofwar")
                    {
                        Console.WriteLine("\nBem-vindo ao sistema");
                    }
                    else
                    {
                        Console.WriteLine("Usuario os senha incorretas");
                        Console.ReadLine();
                        Console.Clear();
                        Main(null);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Usuario os senha incorretas");
                    Console.ReadLine();
                    Console.Clear();
                    Main(null);
                    return;
                }
            }




            Console.ReadKey();

        }
    }
}
