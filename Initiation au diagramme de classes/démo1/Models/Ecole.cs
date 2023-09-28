using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace démo1.Models
{
    public class Ecole
    {
        
        #region Enumérations
        public enum Niveaux
        {
            PRIMAIRE,
            SECONDAIRE,
            ADULTE
        }
        #endregion
        #region Constantes
        private const int PLACES_GROUPE_MAX = 35;
        #endregion

        #region Champs
        private int _iNbElevesDéplacés = 0;
        #endregion

        #region Propriétés
        public string Nom
        {
            get;
            set;
            
        }
        public Niveaux Niveau
        {
            get;
            set;
            
        }

        public Directeur Directeur
        {
            get ;
            private set;
          
        }

        public List<Eleve> Elèves
        {
            get;
            private set;
            
        }
        #endregion

        #region Méthodes
        public void InscrireElève(string sPrénom, string sNom)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}