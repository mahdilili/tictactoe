using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Formes
{
    public class Cercle : Forme
    {
        #region Propriétés
        public int Rayon { get; set; }

        public override float Aire => (float)(Rayon * Rayon * Math.PI);

        public override float Périmètre => (float)(2 * Rayon * Math.PI);


         
        #endregion
    }
}