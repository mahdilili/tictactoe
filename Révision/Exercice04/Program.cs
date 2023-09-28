using System;

namespace Exercice04
{
    /// <summary>
    /// Auteur: Mahdi Ellili
    /// Description : voir file:///C:/420_2DP/Apprentissages/Revision_des_notions_anterieures.pdf Exercice 04
    /// Date: 2022-02-09
    /// </summary>
    class Program
    {
        #region Champs
        static int[] _aiTableau = null;
        #endregion
        #region Méthodes
        /// <summary>
        /// Auteur: Mahdi Ellili
        /// Description: Sert à rémplir un tableau à une dimension de valeurs entières 
        /// Date:2022-02-11
        /// </summary>
        /// <param name="sValeurs">Chaine contenant les valeurs numériques séparées par des vigrules</param>
        static void RemplirTableau1D(string sValeurs)
        {
            //Variables locales.
            string[] asValeursSéparées = null;
            //Séparer les valeurs en fonction de la virgule.
            asValeursSéparées = sValeurs.Split(',');

            //Allouer le tableau d'entiers
            _aiTableau = new int[asValeursSéparées.Length];

            //Remplir le tableau d'entiers.
            for (int iIndex = 0; iIndex < asValeursSéparées.Length; iIndex++)
            {
                //_aiTableau[iIndex] = int.Parse(asValeursSéparées[iIndex]);
                if (!int.TryParse(asValeursSéparées[iIndex], out _aiTableau[iIndex]))
                    Console.WriteLine("Erreur de valeur à l'index #" + iIndex + ", valeur: " + asValeursSéparées[iIndex] + "!");

            }
        }
        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: Afficher les valeurs du tableau
        /// Date:2022-02-11
        /// </summary>
        /// <param name="aiTableau">Le tableau</param>
        static void AfficherTableau1D (int[] aiTableau)
        {
            for (int iIndex1 = 0; iIndex1 < _aiTableau.Length; iIndex1++)
                Console.Write(iIndex1+"\t");
            Console.WriteLine();
            
            for (int iIndex = 0; iIndex < _aiTableau.Length; iIndex++)
            
                Console.Write(aiTableau[iIndex] + "\t");
            
        }
        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: Sert à permuter deux éléments dans un tableau.
        /// Date:2022-02-11
        /// </summary>
        /// <param name="iIndexSource"></param>
        /// <param name="iIndexDest"></param>
        static void Permuter (byte byIndexSource, byte byIndexDest)
        {
            //Variables locales.
            int iTemp = 0;

            iTemp = _aiTableau[byIndexSource];
            _aiTableau[byIndexSource] = _aiTableau[byIndexDest];
            _aiTableau[byIndexDest] = iTemp;

            //2éme méthode

          //  (_aiTableau[byIndexSource],_aiTableau[byIndexDest])= (_aiTableau[byIndexDest], _aiTableau[byIndexSource])
        }
        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: Demander et valdier l'index de tableau 1D
        /// Date:2022-02-11
        /// </summary>
        /// <param name="sMessage">Le message de question</param>
        /// <param name="sErreur">le message d'erreur</param>
        /// <returns>Index validé</returns>
        static sbyte DemanderIndex(string sMessage, string sErreur)
        {
            //Variables locales.
            string sRéponse = "";
            bool bValidation = false;
            sbyte sbyIndex = 0;
            do
            {
                
                Console.Write(sMessage);
                sRéponse = Console.ReadLine();
                bValidation = sbyte.TryParse(sRéponse, out sbyIndex)  && sbyIndex < _aiTableau.Length;
                //&& sbyIndex >= 0
                if (!bValidation)
                    Console.WriteLine( sErreur);
            } while (!bValidation);
            return sbyIndex;

        }
   
        #endregion
        static void Main(string[] args)
            {
            //Variables locales
            string sValeurs = "";
            
            
            sbyte sbySource = 0;
            sbyte sbyDestination = 0;
                //Demander les valeurs.

                Console.Write("Entrer vos valeurs: ");
                sValeurs = Console.ReadLine();

                //Remplir le tableau 1D 
                RemplirTableau1D(sValeurs);

            Console.Clear();
            //Afficher tableau
            do
            {
                Console.Clear();
                AfficherTableau1D(_aiTableau);

                Console.WriteLine();
                //Demander l'index de la source 
                sbySource = DemanderIndex("Entrer le numéro de l'index source: ", "Erreur: Mauvais index source doit être entre 0 et " + (_aiTableau.Length - 1) + " !");

                sbyDestination = DemanderIndex("Entrer le numéro de l'index Destination: ", "Erreur: Mauvais index destination doit être entre 0 et " + (_aiTableau.Length - 1) + " !");

                //Permuter les éléments
                if(sbySource>=0 && sbyDestination>=0)
                Permuter((byte)sbySource, (byte)sbyDestination);
            } while (sbySource >= 0 && sbyDestination >= 0);
        }
        
    }
}
