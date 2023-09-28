using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaireAutomobiles.Models
{
    /// <summary>
    /// Auteur: Mahdi Ellili
    /// Description : Permet de conserver les informations asociès ç une automobile
    /// Date: 2022-04-01
    /// </summary>
    public class Automobile
    {

       
        #region Propriétés

        public int ID { get; set; }
        public string Nom { get; set; }
        public short  Année { get; set; }
        public string Marque { get; set; }
        public string Modèle { get; set; }
        public string Couleur { get; set; }
        public string Constructeur { get; set; }
        public bool Neuf { get; set; }
        public bool Effacer { get; set; }

        #endregion

        #region Méthodes
        public Automobile Cloner()
        {

            return (Automobile)this.MemberwiseClone();
        }
        #endregion
    }
}
