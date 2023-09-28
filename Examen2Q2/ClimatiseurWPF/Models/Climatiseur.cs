using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatiseurWPF.Models
{
    public class Climatiseur
    {
        #region Propriétés
        public string Marque { get; set; } 
        public string Modèle { get; set; }
        public float Prix { get; set; } 
        public int BTU { get; set; } 
        public DateTime DernierEntretien { get; set; } = DateTime.Today;
        public string Description
        {
            get
            {
                return Marque + " " + Modèle + " " + BTU + " " + Prix + "$, entretien: " + DernierEntretien.ToShortDateString();
            }
        }
        #endregion

       

    }
}
