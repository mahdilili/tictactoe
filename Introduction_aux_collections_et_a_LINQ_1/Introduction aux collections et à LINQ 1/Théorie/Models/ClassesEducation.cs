using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models.Education
{
    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur une évaluation.
    /// Date: 2013-04-05
    /// </summary>
    public class Evaluation
    {
        #region Propriétés
        // Propriétés auto implémentées.
        public string DA { get; set; }
        public string Description { get; set; }
        public int Note { get; set; }
        #endregion

        #region Méthodes
        // Modification du comportement de ToString()
        public override string ToString()
        {
            return string.Format("DA = {0} Desctiption = {1} Notes = {2}", DA, Description, Note);
        }
        #endregion
    }

    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un étudiant et ses notes.
    /// Date: 2013-04-05
    /// </summary>
    public class Etudiant
    {
        #region Propriétés
        // Propriétés auto implémentées.
        public string DA { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Groupe { get; set; }
        public string CodeCours { get; set; }
        public List<int> Notes { get; set; } = new List<int>();
        #endregion

        #region Méthode(s)
        // Modification du comportement de ToString()
        public override string ToString()
        {
            return string.Format("DA = {0}, Prenom = {1}, Nom = {2} ", DA, Prenom, Nom);
        }
        #endregion
    }

    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Cette classe permet de conserver les informations sur un cours.
    /// Date: 2013-04-05
    /// </summary>
    public class Cours
    {
        // Propriétés auto implémentées.
        public string CodeCours { get; set; }
        public string Nom { get; set; }
        public string Ponderation { get; set; }
    }
}
