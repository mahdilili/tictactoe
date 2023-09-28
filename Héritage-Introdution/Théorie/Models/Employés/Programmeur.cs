using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Employés
{
    public class Programmeur : Employé
    {
        public List<string> Langages
        {
            get => default;
            set
            {
            }
        }

        public void Analyser()
        {
            throw new System.NotImplementedException();
        }

        public void Programmer()
        {
            throw new System.NotImplementedException();
        }

        public void Documenter()
        {
            throw new System.NotImplementedException();
        }
    }
}