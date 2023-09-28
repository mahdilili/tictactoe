using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Employés
{
    public class Gestionnaire : Employé
    {
        public bool VoitureFournie
        {
            get => default;
            set
            {
            }
        }

        public List<string> Projets
        {
            get => default;
            set
            {
            }
        }

        public short NombreEmployés
        {
            get => default;
            set
            {
            }
        }

        public void PlanifierProjet()
        {
            throw new System.NotImplementedException();
        }

        public void DébuterProjet()
        {
            throw new System.NotImplementedException();
        }

        public void TerminerProjet()
        {
            throw new System.NotImplementedException();
        }
    }
}