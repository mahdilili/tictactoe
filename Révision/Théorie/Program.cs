using System;

namespace Théorie
{
   
    class Program
    {/// <summary>
     /// Auteur: Mahdi Ellili
     /// Description: Créer un programme qui consiste à demander à l’usager de 
     /// saisir un prix unitaire, une quantité et d’afficher le sous-total
     /// avant taxes, montant de la TVQ, montant de la TPS et le total.
     /// Date: 2022-02-09
     /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variables locales 
            string sRéponse = "";
            float fPrixU = 0f;
            int iQuantité = 0;
            bool bValid = false ;
            float fTotal = 0;
            float fTPS = 0.0f;
            float fTVQ = 0.0f;
            float fTotalFinal = 0.0f;
            // Permet de définir le point comme décimal. Configuration anglaise.
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            //Demander les informations 

            do
            {


                Console.Write("Entrer le prix unitaire: ");
                sRéponse = Console.ReadLine();
                bValid = float.TryParse(sRéponse, out fPrixU);
                if (!bValid)
                    Console.WriteLine("ERREUR! entrer un prix valdie!");
            } while (!bValid);
            bValid = false;
            do
            {
                Console.Write("Entrer la quantité: ");
                sRéponse = Console.ReadLine();
                bValid = int.TryParse(sRéponse, out iQuantité);
                if (!bValid)
                    Console.WriteLine("ERREUR! entrer une quantité valdie!");
            } while (!bValid);

            // Effectuer les calculs 

            fTotal = fPrixU * iQuantité;
            fTPS= (float)(fTotal * 0.05);
            fTVQ = (float)(fTotal * 0.09975);

            fTotalFinal = fTotal + fTPS + fTVQ;

            //Afficher la facture 
            Console.WriteLine("****Facture****");
            Console.WriteLine("Sous-Total....: "+fTotal.ToString("0.00$"));
            Console.WriteLine($"Montant TVQ..: {fTVQ:0.00$}");
            Console.WriteLine("Montant TPS..: "+fTPS.ToString("0.00$"));

            Console.WriteLine("Total...:"+fTotalFinal.ToString("0.00$"));


        }
    }
}
