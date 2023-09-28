using System;

namespace Exercice02
{
    class Program
    {
        
        #region Champs
        static Random _rnd = new Random();
        #endregion
        #region Méthodes
       static private byte TirerDé()
        {
            // Signature : TirerDé() 
            return (byte)_rnd.Next(1, 7);
        }

        static private byte TirerDé(byte byNbFaces)
        {
            //Signature : TirerDé(byte)
            return (byte)_rnd.Next(1, byNbFaces + 1);
        }

        /// <summary>
        /// Auteur: Mahdi Ellili
        /// Description: Exercice 04
        /// </summary>
        /// <param name="cSéparateur">séparateur</param>
        /// <param name="sMots">La chaine à concaténér</param>
        /// <returns>chaine concaténeé et séparé</returns>
        static private string Concaténer(char cSéparateur , params string[] sMots)
        {
            //Variables locales 
            string sChaine = "";

            for (int iCpt = 0; iCpt < sMots.Length; iCpt++)
            {
                
                    sChaine += sMots[iCpt];
                if (iCpt != sMots.Length)
                    sChaine +=cSéparateur;
                
            }
            return sChaine;
        }
        static public void SéparerTéléphone(string sNum,ref string sIndicRég, ref string sPréfix, ref string sSuffixe)
        {
            if (sNum.Length == 12)
            {
                sIndicRég = sNum.Substring(0, 3);
                sPréfix = sNum.Substring(4, 3);
                sSuffixe = sNum.Substring(8, 4);
            }
        }

        static public void permuter (ref int inb1, ref int inb2)
        {
            //Variable locales
            int iTemp = 0;
            iTemp = inb1;
            inb1 = inb2;
            inb2 = iTemp;
           
        }

        static private void SéparerChemin(string sChemin,
                                            out string sLecteur,
                                            out string sDossier,
                                            out string sNomFichier)
        {
            //Variables locales
            string[] asValeurs = null;

            //Initialiser les variables sortantes
            sLecteur = "";
            sDossier = "";
            sNomFichier = "";

            //Séparer les éléments.
            asValeurs = sChemin.Split('\\');

            if (asValeurs.Length == 1)
            {
                if (asValeurs[0].Contains(":"))
                    sLecteur = asValeurs[0];
                else
                    sNomFichier = asValeurs[0];

            } 
            else if (asValeurs.Length >= 2)
            {
                sLecteur = asValeurs[0];
                sNomFichier = asValeurs[asValeurs.Length - 1];

                for (int iIndex = 1; iIndex < asValeurs.Length - 1; iIndex++)

                    sDossier += asValeurs[iIndex];

            }
           
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("TirerDé(): " + TirerDé());
            Console.WriteLine("TirerDé(): " + TirerDé(20));


            //Exercice 4
            Console.Write(Concaténer(',', "Hello", "World"));


            //Variables locales 
            string sIndicRég = "";
            string sPréfix = "";
            string sSuffixe = "";
           
            //Exercice 5: 
                SéparerTéléphone("450-234-1234", ref sIndicRég,  ref sPréfix, ref sSuffixe);
            //On peut utiliser out
            //Exercice 06

            //Variables lcoales
            int is1 = 3;
            int is2 = 5;
            Console.WriteLine();
            Console.WriteLine($"Nb1: { is1}, Nb2: {is2}");
         
            permuter(ref is1, ref is2);
            Console.WriteLine($"Nb1: { is1}, Nb2: {is2}");


            // Exercice 7

            //Variables locales
            string sLecteur;
            string sDossier;
            string sFichier;
            SéparerChemin("C:\\Temp\\texte.txt", out sLecteur, out sDossier, out sFichier);
            Console.WriteLine("Lecteur: "+sLecteur);
            Console.WriteLine("Dossier: " + sDossier);
            Console.WriteLine("Fichier: " + sFichier);




        }
    }
}
