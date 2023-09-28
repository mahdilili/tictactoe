using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Ecole
{
    public sealed class Professeur : Personne
    {
        public List<string> Cours { get; set; } = new List<string>();

        #region Constructeurs
        public Professeur()
        {
            Clé = CréerIdUnique('P');
        }
        #endregion
    }
}