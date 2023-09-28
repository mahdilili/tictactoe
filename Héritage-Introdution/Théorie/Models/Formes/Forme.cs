using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Théorie.Models.Formes
{
    public abstract class Forme
    {
        #region propriétés
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Brush CouleurFond { get; set; }

        public abstract float Aire { get; }
        public abstract float Périmètre { get;  }
        #endregion
    }
}