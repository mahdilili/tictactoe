using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02.Models
{

    public class STHDateException : Exception
    {
        #region Énumérations
        public enum États
        {
            MauvaisJour,
            MauvaisMois,
            MauvaiseAnnée
        }
        #endregion
        #region Propriétés
        public États État { get; set; }
        #endregion
        #region Constructeurs
        public STHDateException(États état)
        {
            État = état;
        }
        #endregion
        
    }
   

    public class STHDate
    {
        private byte _iJour;
        public byte Jour
        {
            get
            {
                return _iJour;
            }
            set
            {
                if (value >= 1 && value <= 7)
                    _iJour = value;
                else
                    //throw new Exception("Mauvais numéro de jour!!!");
                    throw new STHDateException(STHDateException.États.MauvaisJour);
            }
        }
    }

}
