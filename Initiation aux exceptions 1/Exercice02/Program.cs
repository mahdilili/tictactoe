using System;
using Exercice02.Models;
namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables locales

            int iDividende = 5;
            int iDiviseur = 0;
            float fResultat = 0;
            string sRéponse = "";
            Exercice exercices = new Exercice();
            STHDate date = new STHDate();

            try
            {
                //Exercice #2

                Console.WriteLine("Entrer le dividende: ");
                sRéponse = Console.ReadLine();
                iDividende = int.Parse(sRéponse);

                Console.WriteLine("Entrer le diviseur: ");
                sRéponse = Console.ReadLine();
                iDiviseur = int.Parse(sRéponse);


                fResultat = exercices.Diviser(iDividende, iDiviseur);
                Console.WriteLine("Division: " + fResultat);


                //Exercice #5
                date.Jour = 4;
                date.Jour = 12;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ERREUR: Division par zéro.");
                Console.WriteLine("Redémarrez l'application en vérifiant la saisie.");
            }
            catch(STHDateException ex)
            {
                switch (ex.État)
                {
                    case STHDateException.États.MauvaisJour:
                        Console.WriteLine("ERREUR: Mauvais jour!");
                        break;
                    case STHDateException.États.MauvaisMois:
                        break;
                    case STHDateException.États.MauvaiseAnnée:
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR:" + ex.Message);
                Console.WriteLine("Le programme vient de quitter. Contactez...");
            }
        
            

        }
    }
}
