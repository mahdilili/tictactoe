using System;
using System.IO;
using System.Collections.Generic;
namespace Exercice05
{
    class Program
    {
        #region Méthodes
        static int[,] RemplirTableau2DFichier(string sNomFichier)
        {
            //Variables locales.
            StreamReader sr = null;
            int[,] aiTableauTemp = null;
            string sLigne = "";
            List<string> Lignes = new List<string>();
            int iNbLignes = 0;
            int iNbColonnes = 0;
            string[] asColonnes = null;
            if (File.Exists(sNomFichier))
            {
                //Ouvrir le fichier 
                sr = new StreamReader(sNomFichier);
                
                while(!sr.EndOfStream)
                    Lignes.Add(sr.ReadLine());
                //Fermer le fichier
                sr.Close();

                    
                iNbLignes = Lignes.Count;
                if (iNbLignes>0)
                {
                    asColonnes = Lignes[0].Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    iNbColonnes = asColonnes.Length;
                }
                //Allouer les dimensions du tableau 2D.
                aiTableauTemp = new int[iNbLignes,iNbColonnes];

                //Remplir le tableau avec les valeurs.
                for (int iLigne = 0; iLigne < Lignes.Count; iLigne++)
                {
                    asColonnes = Lignes[iLigne].Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    for (int iColonne = 0; iColonne < asColonnes.Length; iColonne++)
                    
                      if (!int.TryParse(asColonnes[iColonne], out aiTableauTemp[iLigne, iColonne]))
                            Console.WriteLine("ERREUR: Impossible de convertir la valeur à la position "+iColonne);
                    
                }
            }

            return aiTableauTemp;
        }
        /// <summary>
        /// Auteur:Mahdi ELlili
        /// Description: une méthode qui affiche tout les tableau 2D
        /// Date:2022-02-16
        /// </summary>
        /// <param name="aiTableau">Tableau qui sera affiché</param>
        static void AfficherTableau2D (int[,] aiTableau)
        {
            for (int iLigne = 0; iLigne < aiTableau.GetLength(0); iLigne++)
            {
                for (int iColonne = 0; iColonne < aiTableau.GetLength(1); iColonne++)

                    Console.Write(aiTableau[iLigne, iColonne] + "\t");

                Console.WriteLine();//Changement de ligne
            }
            
        }

        static int[,] Retourner(int[,] aiTableauSource)
        {
            int[,] aiTableauTourné = new int[aiTableauSource.GetLength(1),aiTableauSource.GetLength(0)];

            //Transférer les valeurs de la source vers la destination

            for (int iLigne = 0; iLigne < aiTableauTourné.GetLength(0); iLigne++)
            
                for (int iColonne = 0; iColonne < aiTableauTourné.GetLength(1); iColonne++)
                
                    aiTableauTourné[iLigne, iColonne] = aiTableauSource[iColonne, iLigne];
                
            
            return aiTableauTourné;
        }
        #endregion
        static void Main(string[] args)
        {
            //Variables locales 
            string sLigne = "";
            int[,] aiTableauSource = null;
            int[,] aiTableauDestination = null;
            aiTableauSource = RemplirTableau2DFichier("exercice.txt");


            // Afficher le tableau d'origine

            Console.WriteLine("Tableau SOURCE: ");
            AfficherTableau2D(aiTableauSource);

            //Retourner le tableau SOURCE 
            aiTableauDestination = Retourner(aiTableauSource);

            //Afficher le tableau tourné.

            Console.WriteLine("Tableau DESTINATION: ");
            AfficherTableau2D(aiTableauDestination);


        }
    }
}
