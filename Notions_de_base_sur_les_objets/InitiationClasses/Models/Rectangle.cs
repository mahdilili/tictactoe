using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiationClasses.Models
{
    class Rectangle
    {
        #region Enumération

        #endregion

        #region Constantes
        
        #endregion
        #region Champs
        private int _iHauteur = 0;
        private int _iLargeur = 0;
        #endregion
        #region Propriétés 

        public int Hauteur
        {
            get
            {
                return _iHauteur;
            }
            set
            {
                _iHauteur = value;
            }
        }
        
        public int Largeur
        {
            get
            {
                return _iLargeur;
            }
            set
            {
                _iLargeur = value;
            }
        }

        public int Surface
        {
            get
            {
                return CalculerSurface();
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Auteur: Mahdi Ellili
        /// Description: Permet de définir de valeurs par défaut
        /// Date:2022-
        /// </summary>
        public Rectangle()
        {
            _iHauteur = 4;
            _iLargeur = 6;
        }
        public Rectangle(int iHateur, int iLargeur)
        {
            _iHauteur = iHateur;
            _iLargeur = iLargeur;
        }
        public Rectangle(string sHateur, string sLargeur)
        {
            int.TryParse(sHateur, out _iHauteur);
            int.TryParse(sLargeur, out _iLargeur);
        }
        #endregion
        #region Méthodes
        public int CalculerSurface()
        {
            return _iHauteur * _iLargeur;
        }
        public void DéfinirValeurs( int iHauteur, int iLargeur)
        {
            _iHauteur = iHauteur;
            _iLargeur = iLargeur;
        }
        #endregion
    }
}
