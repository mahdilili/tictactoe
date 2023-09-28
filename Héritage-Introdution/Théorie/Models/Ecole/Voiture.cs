using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Ecole
{
    public class Voiture
    {
        public int NbKmParcourus
        {
            get;set;
        }

        public DateTime DateDébut
        {
            get; set;
        }

        public DateTime DateFin
        {
            get; set;
        }

        public bool Active
        {
            get; set;
        }
    }
}