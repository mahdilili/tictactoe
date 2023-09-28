using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Théorie.Models.Ecole
{
    public interface IVoitureCollection
    {
        #region Propriétés
        public int NbVoitures { get; }
        #endregion
        #region Méthodes
        public void Enregistrer(Voiture voiture);
       
        #endregion
    }
}
