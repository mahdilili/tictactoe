using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie.Models.Ecole
{
    class Communicateur : Personne, IVoitureCollection
    {
        #region Champs
        private List<Voiture> _voitures = new List<Voiture>();
        #endregion
        #region Propriétés
        public List<string> Evénements { get; set; } = new List<string>();

        public int NbVoitures => _voitures.Count;

        public void Enregistrer(Voiture voiture)
        {
            _voitures.Add(voiture);
        }
        #endregion
    }
}
