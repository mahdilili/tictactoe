using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Théorie.Models.Ecole
{
    public sealed class Directeur : Personne, IVoitureCollection
    {
        #region Champs
        private List<Voiture> _voitures = new List<Voiture>();
        #endregion
        #region Propriétés

        public List<string> Projets { get; set; } = new List<string>();

        public int NbVoitures => _voitures.Count;
        #endregion

        #region Constructeurs
        public Directeur()
        {
            Clé = CréerIdUnique('D');
        }
        
        #endregion
        public Directeur (string sPrénom, string sNom)
        {
            Prénom = sPrénom;
            Nom = sNom;
        }

        public void Enregistrer(Voiture voiture)
        {
            _voitures.Add(voiture);
        }
    }

}