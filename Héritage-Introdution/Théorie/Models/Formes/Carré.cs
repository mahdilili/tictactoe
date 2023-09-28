using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Formes
{
    public class Carré : Forme
    {
        public int Coté { get; set; }

        // public override int Aire => Coté * Coté;    //Si une seule ligne 

        public override float Aire
        {
            get
            {
                return Coté * Coté;
            }
        }

        public override float Périmètre => 4 * Coté;
    }
}