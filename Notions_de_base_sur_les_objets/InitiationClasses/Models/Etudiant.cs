using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiationClasses.Models
{
    class Etudiant
    {
        #region Enumérations
        public enum ValidationNote
        {
            Succès, 
            Position,
            Note
        }
        #endregion
        #region Champs
        private string _sNom = "";
        private string _sPrénom = "";
        private string _sNoDA = "";
        private DateTime _Naissance;
        private byte[] _abyNotes = new byte[5];

        #endregion

        #region Constructeurs
        public Etudiant()
        {

        }
        public Etudiant(string sNom, string sPrénom, string sNoDA, DateTime Naissance)
        {
            DefinirInfos(sNom, sPrénom, sNoDA, Naissance);
        }
        #endregion

        #region Méthodes
        public float CalculerMoyenne()
        {
            //Variables locales
            float fMoyenne = 0f;

            foreach (byte byNote in _abyNotes)
            {
                fMoyenne += byNote;
            }

            fMoyenne = fMoyenne / _abyNotes.Length;

            return fMoyenne;
        }

        public void DefinirInfos (string sNom, string sPrénom, string sNoDA, DateTime Naissance)
        {
            _sNom = sNom;
            _sPrénom = sPrénom;
            _sNoDA = sNoDA;
            _Naissance = Naissance;
        }

        public ValidationNote AttribuerNote (byte byNote, byte byPosition)
        {
            //Variables locales.
            
            ValidationNote Valide = ValidationNote.Succès;

            if (!(byPosition >= 1 && byPosition <= 5))
                Valide = ValidationNote.Position;
            
             else  if (!(byNote >= 0 && byNote <= 100))
                Valide = ValidationNote.Note;
            else
                _abyNotes[byPosition - 1] = byNote;
            
           

            return Valide;
        }


        public string ObtenirSommaire()
        {
            return _sPrénom + " " + _sNom + " (" + _sNoDA + "), date de naissance : " + _Naissance.ToString("yyyy-MM-DD") + ", Moyenne : " + CalculerMoyenne();
            
        }

        #endregion
    }
}
