using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Employés
{
    public class Vendeur : Employé
    {
        public bool VoitureFournie
        {
            get => default;
            set
            {
            }
        }

        public int NbKmParcourus
        {
            get => default;
            set
            {
            }
        }

        public void AppelerClient()
        {
            throw new System.NotImplementedException();
        }

        public void RencontrerClient()
        {
            throw new System.NotImplementedException();
        }

        public void SignerContrat()
        {
            throw new System.NotImplementedException();
        }
    }
}