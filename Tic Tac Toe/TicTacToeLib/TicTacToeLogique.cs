using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class TicTacToeLogique
    {
        #region Enumérations
        public enum Jetons
        {
            Vide,
            O,
            X
        }

        public enum état
        {
            MauvaiseCoordonnées,
            NonVide,
            DépotRéussi,
            Gagnant,
            PartieNulle

        }
        #endregion


        #region Champs
        private Jetons[,] _grille = new Jetons[3, 3];
        private byte[,] _abyCombinaisonsGagnantes =
        {
         //  L,C   L,C   L,C
            {0,0,  0,1,  0,2,   },          //première ligne horizontale
            {1,0,  1,1,  1,2,   },          //deuxième ligne horizontale
            {2,0,  2,1,  2,2,   },          //Troisième ligne horizontale

            {0,0,  1,0,  2,0,   },          //première ligne Verticale
            {0,1,  1,1,  2,1,   },          //deuxième ligne Verticale
            {0,2,  1,2,  2,2,   },          //Troisième ligne Verticale

            {0,1,  1,1,  2,2,   },          //ligne diagonale \
            {0,2,  1,1,  2,0,   },          //ligne diagonale /
         

        };
        #endregion

       

        #region Propriétés
        public Jetons JetonCourant { get; private set; } = Jetons.O;
        public Jetons[,] Grille { get => _grille; }
        public Options Options { get;private set; } = new Options();
        #endregion
        #region Méthodes 
        public void ChangerJetonDépart (Jetons jeton)
        {
            JetonCourant = jeton;
        }
        public état Déposer (int iLigne , int iColonne)
        {
            if (iLigne >= 1 && iLigne <= _grille.GetLength(0) &&
                iColonne >= 1 && iLigne <= _grille.GetLength(1))
            {
                // Valider si la case est vide.
                if (_grille[iLigne - 1 , iColonne - 1] == Jetons.Vide)
                {
                    _grille[iLigne - 1, iColonne -1] = JetonCourant;

                    if (ValiderGagnant())
                        return état.Gagnant;

                    if (ValiderPartieNulle())
                        return état.PartieNulle;

                    //JetonCourant = JetonCourant == Jetons.O ? Jetons.X : Jetons.O;
                     //2 émé méthode pour ligne dessus 
                    if (JetonCourant == Jetons.O)
                        JetonCourant = Jetons.X;
                    else
                        JetonCourant = Jetons.O;
                    
                    return état.DépotRéussi;
                }
                    else
                            return état.NonVide;

            }
            else
                return état.MauvaiseCoordonnées;
        }
        /// <summary>
        /// Auteur: Mahdi Ellili
        /// Description : Permet de vider la grille
        /// Date: 2022-02-25
        /// </summary>
        public void RénitialiserPartie ()
        {
            for (int iLigne = 0; iLigne < _grille.GetLength(0); iLigne++)
            
                for (int iColonne = 0; iColonne < _grille.GetLength(1); iColonne++)
                
                    _grille[iLigne, iColonne] = Jetons.Vide;
                
            
        }

        /// <summary>
        /// Auteur:mahdi Ellili
        /// </summary>
        /// <returns></returns>
        private bool ValiderPartieNulle()
        {
            for (int iLigne = 0; iLigne < _grille.GetLength(0); iLigne++)

                for (int iColonne = 0; iColonne < _grille.GetLength(1); iColonne++)

                    if (_grille[iLigne, iColonne] == Jetons.Vide)
                        return false;

                    return true;
        }

        private bool ValiderGagnant()
        {
            for (int iComb = 0; iComb < _abyCombinaisonsGagnantes.GetLength(0); iComb++)
            {
                if (_grille[_abyCombinaisonsGagnantes[iComb, 0],_abyCombinaisonsGagnantes[iComb, 1]] == JetonCourant &&
                        _grille[_abyCombinaisonsGagnantes[iComb, 2], _abyCombinaisonsGagnantes[iComb, 3]] == JetonCourant &&
                        _grille[_abyCombinaisonsGagnantes[iComb, 4], _abyCombinaisonsGagnantes[iComb, 5]] == JetonCourant)
                        return true;

            }
            return false;
        }
        #endregion
    }
}
