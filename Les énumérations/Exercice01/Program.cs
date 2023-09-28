using System;

namespace Exercice01
{
    class Program
    {
        #region énumérations
        public enum Jours         //Définition 
        {
            Dimanche,  //O
            Lundi,
            Mardi, 
            Mercredi, 
            Jeudi, 
            Vendredi, 
            Samedi

        }
        #endregion
        #region Constantes

        #endregion
        #region Champs

        #endregion
        #region Propriétés

        #endregion
        #region Méthodes

        #endregion
        static void Main(string[] args)
        {
            //Déclaration des variables locales 
            Jours jours;
            ConsoleKey Mouvement;
            // jour=(Jours)4;

            jours = Jours.Vendredi;
            Mouvement = (ConsoleKey)jours;
            Console.WriteLine(jours);
           
        }
    }
}
