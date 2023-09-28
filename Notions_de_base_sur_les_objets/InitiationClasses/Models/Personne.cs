using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiationClasses.Models
{
    class Personne
    {
        #region Champs



        #endregion
        #region Propriétés

        private string _sNom="";
        private string _sPrénom="";
        private int _iAge=0;
        private string _sTéléphone="";

        public string Nom
        {
            get { return _sNom; }
            set { _sNom = value; }
        }

        

        public string Prénom
        {
            get { return _sPrénom; }
            set { _sPrénom = value; }
        }

        public int Age
        {
            get { return _iAge; }
            set { _iAge = value; }
        }

        public string Téléphone
        {
            get { return _sTéléphone ; }
            set { //Variables locales
                string sNumérique = "";

                foreach (char cCaractère in value)
                    if (char.IsNumber(cCaractère))
                        sNumérique += cCaractère;
                if (sNumérique != "" && sNumérique.Length ==10 )
                    _sTéléphone = sNumérique;
                else
                    _sTéléphone = "N/A"; }
        }

        public string Adresse { get; set; }  // propriétés auto-implémentée

        #endregion

        #region Méthodes
        public float CalculerDuréeVieEnHeures()
        {
            return _iAge * 365.25f * 24;
        }
        #endregion
    }
}
