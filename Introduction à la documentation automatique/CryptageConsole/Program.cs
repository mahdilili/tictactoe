using STHInformatique;
using System;

/// <summary>
/// 
/// </summary>
namespace CryptageConsole
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        #region Champs
        static STHCryptage _crypteur = new STHCryptage();
        #endregion
        static void Main(string[] args)
        {
            // Variables locales.
            // Variables locales.
            string sPhrase = "";
            char cChoix = ' ';
            string sRéponse = "";

            Console.Write("Entrer une phrase: ");
            sPhrase = Console.ReadLine();

            Console.Write("Voulez-vous (E)ncrypter ou (D)écrypter la phrase?: ");
            sRéponse = Console.ReadLine();
            if (char.TryParse(sRéponse, out cChoix))
            {
                if (char.ToLower(cChoix) == 'd') // Décrypter
                    Console.WriteLine("Décryptée: " + _crypteur.Décrypter(sPhrase));
                else
                    Console.WriteLine("Encryptée: " + _crypteur.Encrypter(sPhrase));
            }
            else
                Console.WriteLine("ERREUR: Vous devez entrer un caractère!");
        }
    }
}
