using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Théorie.Models.Ecole
{
    public class Personne
    {
        #region Propriétéss

        public string Nom
        {
            get;
            set;

        }

        public string Prénom
        {
            get;
            set;

        }

        public byte Age
        {
            get;
            set;

        }

        public Image Photo
        {
            get;
            set;

        }

        public string Clé { get; set; }
        #endregion

        #region Constructeurs
        public Personne() : this("Inconnu", "Inconnu", 20)
        {

        }
        public Personne(string sPrénom, string sNom)
        {
            Prénom = sPrénom;
            Nom = sNom;
        }
        public Personne(string sPrénom, string sNom, byte byAge) : this(sPrénom, sNom)
        {
            Age = byAge;
        }
        #endregion
        #region Méthodes
        virtual public string ObtenirRole()
        {
            return " Je suis une personne: " + Prénom + " " + Nom;
        }

        protected string CréerIdUnique(char cType)
        {
            return cType + Guid.NewGuid().ToString();
        }
        #endregion
    }
}