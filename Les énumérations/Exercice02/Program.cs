using System;

namespace Exercice02
{
    
    class Program
    {
        #region énumération
        public enum breuvages
        {
            COKE = 1,       //0
            SEVENUP,         //1
            JUS_POMMES,      //2
            THE_GLACE,       //3
            LAIT,            //4
            NonDéfinie       //5

        }
        #endregion
        #region Méthodes
        static breuvages DemanderBreuvage()
        {
            //variables locales.
            string sRéponse = "";
            byte byChoix = 0;
            bool bValide = false;
            //Demander la valeur.
            do
            {
                Console.Write("Entrez un numéro de breuvage (entre " +
                    (byte)breuvages.COKE + " et " + (byte)breuvages.LAIT + ")");
                sRéponse = Console.ReadLine();
                bValide = byte.TryParse(sRéponse, out byChoix) && byChoix >= (byte)breuvages.COKE && byChoix <= (byte)breuvages.LAIT;
            } while (!bValide);

            return (breuvages)byChoix;
        }
        #endregion
        static void Main(string[] args)
        {
            //Variables locales 

            
            breuvages breuvage=breuvages.NonDéfinie;


            breuvage = DemanderBreuvage();

            Console.WriteLine("Le breuvage choisi est: "+breuvage);
            
        }
        
    }
}
