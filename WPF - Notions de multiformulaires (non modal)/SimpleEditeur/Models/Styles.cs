using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEditeur.Models
{
    public class Styles
    {
        #region Enumérations
        public enum Couleurs
        {
            Noir,
            Blanc,
            Jaune,
            Bleu,
        }
        #endregion
        #region Propriétés
        public bool Gras { get; set; }
        public bool Italique { get; set; }
        public byte Taille { get; set; }

        public Couleurs Couleur { get; set; }

        #endregion
    }
}
