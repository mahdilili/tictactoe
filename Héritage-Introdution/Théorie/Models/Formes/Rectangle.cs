using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Formes
{
    public class Rectangle : Forme
    {
        public int Hauteur { get; set; }
        public int Largeur { get; set; }

        public override float Aire => Hauteur* Largeur;

        public override float Périmètre => (Largeur + Hauteur) * 2;
    }
}