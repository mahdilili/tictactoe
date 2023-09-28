using System;
using ExercicesLib;
namespace CryptageConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables locales.

            STHCryptage crypteur = new STHCryptage();
            string sPhrase = "";
            char cChoix = ' ';
            

            Console.Write("Entrer une phrase: ");
            sPhrase = Console.ReadLine();

            Console.Write("Choisir (E)ncrypter ou (D)décrypter: ");
            cChoix = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (char.ToUpper(cChoix))
            {
                case 'E':
                    Console.WriteLine(crypteur.Encrypter(sPhrase));
                    break;
                case 'D':
                    Console.WriteLine(crypteur.Décrypter(sPhrase));
                    break;
                default:
                    Console.WriteLine("ERREUR: Opération invalide!");
                    break;
            }
            
           
        }
    }
}
