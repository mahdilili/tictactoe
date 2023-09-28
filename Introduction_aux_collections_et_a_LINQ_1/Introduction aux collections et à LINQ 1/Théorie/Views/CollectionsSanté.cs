using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Théorie.Models.Santé;
using System.Windows;

namespace Théorie.Views
{
    partial class MainWindow : Window
    {
        // Liste de patients impliquant une collection imbriquée.
        public List<Patient> _patients = new List<Patient>()
        {
            #region Données 
            new Patient { Prenom = "Jacques", Nom = "Vézina", NAM = "VEZJ87120299", Visites = new List<DateTime> { new DateTime(2005, 03, 20), new DateTime(2006, 03, 03)  },  Remarques = new List<string>() { "Tout est OK.", "Prendre des vitamines", "Il avait un rhume"  } },
            new Patient { Prenom = "Lisa",    Nom = "Roy",    NAM = "ROYL65561199", Visites = new List<DateTime> { new DateTime(1997, 05, 13), new DateTime(1999, 11, 03), new DateTime(2000, 09, 22), new DateTime(2001, 05, 04) }, Remarques = new List<string>() { "Mal de dos", "Bras fracturé", "Plâtre retiré" }  },
            new Patient { Prenom = "Roger",   Nom = "Côté",   NAM = "COTR50081499", Visites = new List<DateTime> { new DateTime(1980, 02, 26), new DateTime(1985, 07, 01), new DateTime(1988, 09, 12) }, Remarques = new List<string>() { "Mal aux oreilles", "Prescription renouvellée", "Vaccin H1N1", "Orteil cassée" }  },
            new Patient { Prenom = "Réjean",  Nom = "Savard", NAM = "SAVR77022899", Visites = new List<DateTime> { new DateTime(1978, 02, 13), new DateTime(1979, 09, 01), new DateTime(2009, 09, 04), new DateTime(2010, 07, 21) }, Remarques = new List<string>() { "Examen routine", "Vaccin H1N1" }  }
            #endregion
        };
    };
}
