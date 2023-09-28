using System;
using System.IO;
using System.Collections.Generic;

namespace Exercice03
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Variables locales

            List<string> prénoms = new List<string>();
            string sRéponse = "";
            string sPrénomEnvers = "";
            int iNbFois = 0;
            char cLettre = ' ';

            //Demander les prénoms

            while (iNbFois < 7)
            {
                Console.Write("Entrer un prénom: ");
                sRéponse = Console.ReadLine();
                prénoms.Add(sRéponse);
                iNbFois++;
            }

            foreach (string sprénom in prénoms)
            {
                cLettre = ' ';
                sPrénomEnvers = "";
                
                for (int icpt = sprénom.Length-1; icpt >= 0; icpt--)
                {
                    cLettre = sprénom[icpt];
                    sPrénomEnvers += cLettre;
                }
                Console.WriteLine(sPrénomEnvers);
                
            }

            // Afficher chaque prénim à l'envers (boucle obligatoire)
            /* foreach (string sValeur in prénoms)
             * {
             * for (int iIndex=sValeur.Length-1; iIndex>=0; iIndex--)
             * Console.Write(sValeur[iIndex]);
             * Console.WriteLine();
             */
            

        }
    }
}
