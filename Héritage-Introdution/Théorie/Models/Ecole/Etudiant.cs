using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Théorie.Models.Ecole;

namespace Théorie.Models.Ecole
{
    #region Propriétés

    public sealed class Etudiant : Personne
    {
        public List<int> Notes { get; set; } = new List<int>();
        #endregion
        #region Méthodes
        public override string ObtenirRole()
        {
            //  return base.ObtenirRole();
            return base. ObtenirRole()+ " Je suis un étudiant.";
        }
        // public string ObtenirRole()
        //{
        //    return "Je suis un étudiant.";
        //}
        #endregion

        #region Constructeurs
        public Etudiant()
        {
            Clé = CréerIdUnique('E');
        }

        public Etudiant(string sPrénom, string sNom, byte byAge) : base (sPrénom, sNom)
        {

        }
        #endregion
    }
}