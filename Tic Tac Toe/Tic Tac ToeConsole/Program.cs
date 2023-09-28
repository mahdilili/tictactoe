using System;
using TicTacToeLib;

namespace Tic_Tac_ToeConsole
{
    class Program
    {
        #region Champs
        static TicTacToeLogique _jeu = new TicTacToeLogique();
        #endregion

        #region Méthodes

        static char JetonToChar(TicTacToeLogique.Jetons jeton)
        {
            //Variables locales
            char cJeton = ' ';
            //  _jeu.Grille[0, 0] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[0, 0];
            switch (jeton)
            {

                case TicTacToeLogique.Jetons.O:
                    cJeton = 'O';
                    break;
                case TicTacToeLogique.Jetons.X:
                    cJeton = 'X';
                    break;

            }
            return cJeton;
        }
        static void AfficherGrille()
        {
            //Console.WriteLine(" "+ (_jeu.Grille[0,0] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[0,0])
            //                + "|" + (_jeu.Grille[0, 1] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[0, 1])
            //                + "|" + (_jeu.Grille[0, 2] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[0, 2]));

            //Console.WriteLine("  | |  ");
            //Console.WriteLine("--+-+--");
            //Console.WriteLine(" " + (_jeu.Grille[1, 0] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[1, 0])
            //               + "|" + (_jeu.Grille[1, 1] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[1, 1])
            //               + "|" + (_jeu.Grille[1, 2] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[1, 2]));
            //Console.WriteLine("--+-+--");
            //Console.WriteLine(" " + (_jeu.Grille[2, 0] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[2, 0])
            //               + "|" + (_jeu.Grille[2, 1] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[2, 1])
            //               + "|" + (_jeu.Grille[2, 2] == TicTacToeLogique.Jetons.Vide ? " " : _jeu.Grille[2, 2]));

            Console.Clear();
            Console.WriteLine(" " + JetonToChar(_jeu.Grille[0, 0])
                            + "|" + JetonToChar(_jeu.Grille[0, 1])
                            + "|" + JetonToChar(_jeu.Grille[0, 2]));

            Console.WriteLine("--+-+--");
            Console.WriteLine(" " + JetonToChar(_jeu.Grille[1, 0])
                            + "|" + JetonToChar(_jeu.Grille[1, 1])
                            + "|" + JetonToChar(_jeu.Grille[1, 2]));
            Console.WriteLine("--+-+--");
            Console.WriteLine(" " + JetonToChar(_jeu.Grille[2, 0])
                           + "|" + JetonToChar(_jeu.Grille[2, 1])
                           + "|" + JetonToChar(_jeu.Grille[2, 2]));
        }

        static void AfficherMessage(string sMessage)
        {
            Console.WriteLine(sMessage);
            Console.WriteLine("Appuyez sur une touche!");
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
            // Variables locales.
  
            string sRéponse = "";
            string[] asCoord = null;
            byte byLigne = 0;
            byte byColonne = 0;
            do
            {
                AfficherGrille();
                Console.Write("Entrer la coordonnée (Tour: " +_jeu.JetonCourant + "):");
                sRéponse = Console.ReadLine();
                if(sRéponse.ToUpper() !="Q")
                {
                    asCoord = sRéponse.Split(',');
                    if (asCoord.Length == 2 &&
                        byte.TryParse(asCoord[0], out byLigne) &&
                        byte.TryParse(asCoord[1], out byColonne))
                    {
                        switch (_jeu.Déposer(byLigne,byColonne))
                        {
                            case TicTacToeLogique.état.MauvaiseCoordonnées:
                                AfficherMessage("ERREUR: Mauvaise coordonnée!");
                                break;
                            case TicTacToeLogique.état.NonVide:
                                AfficherMessage("ERREUR: Case non vide!");
                                break;
                            case TicTacToeLogique.état.DépotRéussi:
                                break;
                            case TicTacToeLogique.état.PartieNulle:
                                AfficherGrille();
                                Console.WriteLine("La partie est nulle!");
                                Console.Write("(Q)uitter ou autre pour recommencer: ");
                                sRéponse = Console.ReadLine();
                                if (sRéponse.ToUpper() != "Q")
                                    _jeu.RénitialiserPartie();
                                break;
                            case TicTacToeLogique.état.Gagnant:
                                AfficherGrille();
                                Console.WriteLine("Les "+_jeu.JetonCourant+" sont les gagants!!!");
                                Console.Write("(Q)uitter ou autre pour recommencer: ");
                                sRéponse = Console.ReadLine();
                                if (sRéponse.ToUpper() != "Q")
                                    _jeu.RénitialiserPartie();
                                break;

                            default:
                                break;
                        }
                    }
                    else
                        AfficherMessage("ERREUR: Mauvaise coordonnée!");

                }


            } while (sRéponse.ToUpper() != "Q");
        }
    }
}
