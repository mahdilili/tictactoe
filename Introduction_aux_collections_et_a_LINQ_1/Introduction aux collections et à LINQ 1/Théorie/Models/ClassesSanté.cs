using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models.Santé
{
    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un patient.
    /// Date: 2013-04-05
    /// </summary>
    public class Patient
    {
        #region Propriétés
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string NAM { get; set; }
        public List<DateTime> Visites { get; set; }
        public List<string> Remarques { get; set; }
        #endregion

        #region Méthode(s)
        // Modification du comportement de ToString()
        public override string ToString()
        {
            return string.Format("NAM = {0}, Prenom = {1}, Nom = {2} ", NAM, Prenom, Nom);
        }
        #endregion
    }
}
