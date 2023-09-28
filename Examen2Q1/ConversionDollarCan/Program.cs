using System;

namespace ConversionDollarCan
{
    class Program
    {
        #region Méthodes
        /// <summary>
        /// Auteur: Mahdi Ellili
        /// Description : méthode qui sert à convertir le montant du dollar canadien en USD, YEN et Peso 
        /// Date: 2022-04-20
        /// </summary>
        /// <param name="fCAD">Montant en dollar canadien</param>
        /// <param name="fUS"> Montant converti en dollar américan</param>
        /// <param name="fYEN">Montant converti en YEN (japon)</param>
        /// <param name="fPeso">Montant converti en Peso (Mexique)</param>
        static void ConvertirDollarsCan(float dollarsCan,ref float dollarsUS, ref float dollarsYen, ref float dollarsPeso)
        {
            dollarsUS = (float)0.7935 * dollarsCan;
            dollarsYen = (float)98.3258 * dollarsCan;
            dollarsPeso = (float)15.9881 * dollarsCan;
            
        }
        #endregion
        static void Main(string[] args)
        {
            // Permet de définir le point comme décimal. Configuration anglaise.
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            //Variables locales
            float fCAD = 0f;
            float fUS = 0f;
            float fYEN = 0f;
            float fPeso = 0f;
            string sRéponse = "";
            bool bValid = false;

            //Demander le montant à convertir 
            do
            {
                Console.Write("Entrer vos dollars canadiens: ");
                sRéponse = Console.ReadLine();
                bValid = float.TryParse(sRéponse, out fCAD);
                if (!bValid)
                    Console.WriteLine("ERREUR: veuillez entrer un montant valide!");
            } while (!bValid);

                ConvertirDollarsCan(fCAD, ref fUS, ref fYEN, ref fPeso);
                Console.Write("US: " + fUS.ToString(".00") + " $ \r\n" +
                              "Yen: " + fYEN.ToString(".00") + "\r\n" +
                              "Peso: " + fPeso.ToString(".00") + "\r\n");
            
        }
    }
}
