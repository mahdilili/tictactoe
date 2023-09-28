using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Théorie.Models.Education;
using System.Windows;

namespace Théorie.Views
{
    partial class MainWindow : Window
    {
        public List<Cours> _cours = new List<Cours>() 
        {
            #region Données 
            new Cours {CodeCours = "GEA", Nom = "Programmation 2", Ponderation = "3-3-3" }, 
            new Cours {CodeCours = "CAC", Nom = "Internet",        Ponderation = "2-2-2"  },
            new Cours {CodeCours = "GEB", Nom = "Config",          Ponderation = "2-2-2"   },
            #endregion
        };

        public List<Etudiant> _etudiants = new List<Etudiant>() 
        {
            #region Données 
            new Etudiant { DA="0981321", Prenom = "Serge",    Nom = "Ouellet",   CodeCours = "GEA"  }, 
            new Etudiant { DA="1234567", Prenom = "Claire",   Nom = "Lamarche",  CodeCours = "CAC"  }, 
            new Etudiant { DA="7654321", Prenom = "Steve",    Nom = "Morel",     CodeCours = "CAC"  }, 
            new Etudiant { DA="0123456", Prenom = "Carl",     Nom = "Girard",    CodeCours = "GEA"  }, 
            new Etudiant { DA="6543210", Prenom = "Dany",     Nom = "Girard" ,   CodeCours = "GEA"  }, 
            new Etudiant { DA="2345678", Prenom = "François", Nom = "Filion",    CodeCours = "GEA"  }, 
            new Etudiant { DA="8765432", Prenom = "Henri",    Nom = "Fortier",   CodeCours = "CAC"  }, 
            new Etudiant { DA="3456789", Prenom = "Hugo",     Nom = "Gagné",     CodeCours = "CAC"  }, 
            new Etudiant { DA="9876543", Prenom = "Laurie",   Nom = "Turcotte",  CodeCours = "GEA"  }, 
            new Etudiant { DA="4567890", Prenom = "Thomas",   Nom = "Audette",   CodeCours = "GEA"  }, 
            new Etudiant { DA="0987654", Prenom = "Edouard",  Nom = "Parenteau", CodeCours = "CAC"  }, 
            new Etudiant { DA="5678901", Prenom = "Michel",   Nom = "Turcotte",  CodeCours = "CAC"  }, 
            new Etudiant { DA="1098765", Prenom = "Zoe",      Nom = "Forget",    CodeCours = "GEA"  } 
            #endregion
        };

        public List<Evaluation> _evaluations = new List<Evaluation>()
        {
            #region Données 
            new Evaluation { DA="1098765", Description="TP1", Note=67},
            new Evaluation { DA="1098765", Description="TP2", Note=78},
            new Evaluation { DA="1098765", Description="TP3", Note=80},
            new Evaluation { DA="1098765", Description="Examen mi-session", Note=90},
            new Evaluation { DA="1098765", Description="Examen final", Note=81},
            new Evaluation { DA="5678901", Description="TP1", Note=94},
            new Evaluation { DA="5678901", Description="TP2", Note=92},
            new Evaluation { DA="5678901", Description="TP3", Note=91},
            new Evaluation { DA="5678901", Description="Examen mi-session", Note=91},
            new Evaluation { DA="5678901", Description="Examen final", Note=90},
            new Evaluation { DA="0987654", Description="TP1", Note=96},
            new Evaluation { DA="0987654", Description="TP2", Note=85},
            new Evaluation { DA="0987654", Description="TP3", Note=91},
            new Evaluation { DA="0987654", Description="Examen mi-session", Note=60},
            new Evaluation { DA="0987654", Description="Examen final", Note=66},
            new Evaluation { DA="4567890", Description="TP1", Note=99},
            new Evaluation { DA="4567890", Description="TP2", Note=82},
            new Evaluation { DA="4567890", Description="TP3", Note=81},
            new Evaluation { DA="4567890", Description="Examen mi-session", Note=79},
            new Evaluation { DA="4567890", Description="Examen final", Note=84},
            new Evaluation { DA="9876543", Description="TP1", Note=68},
            new Evaluation { DA="9876543", Description="TP2", Note=79},
            new Evaluation { DA="9876543", Description="TP3", Note=88},
            new Evaluation { DA="9876543", Description="Examen mi-session", Note=92},
            new Evaluation { DA="9876543", Description="Examen final", Note=80},
            new Evaluation { DA="3456789", Description="TP1", Note=92},
            new Evaluation { DA="3456789", Description="TP2", Note=90},
            new Evaluation { DA="3456789", Description="TP3", Note=83},
            new Evaluation { DA="3456789", Description="Examen mi-session", Note=78},
            new Evaluation { DA="3456789", Description="Examen final", Note=68},
            new Evaluation { DA="8765432", Description="TP1", Note=93},
            new Evaluation { DA="8765432", Description="TP2", Note=92},
            new Evaluation { DA="8765432", Description="TP3", Note=80},
            new Evaluation { DA="8765432", Description="Examen mi-session", Note=87},
            new Evaluation { DA="8765432", Description="Examen final", Note=76},
            new Evaluation { DA="2345678", Description="TP1", Note=99},
            new Evaluation { DA="2345678", Description="TP2", Note=86},
            new Evaluation { DA="2345678", Description="TP3", Note=90},
            new Evaluation { DA="2345678", Description="Examen mi-session", Note=94},
            new Evaluation { DA="2345678", Description="Examen final", Note=84},
            new Evaluation { DA="6543210", Description="TP1", Note=35},
            new Evaluation { DA="6543210", Description="TP2", Note=72},
            new Evaluation { DA="6543210", Description="TP3", Note=91},
            new Evaluation { DA="6543210", Description="Examen mi-session", Note=70},
            new Evaluation { DA="6543210", Description="Examen final", Note=60},
            new Evaluation { DA="0123456", Description="TP1", Note=97},
            new Evaluation { DA="0123456", Description="TP2", Note=89},
            new Evaluation { DA="0123456", Description="TP3", Note=85},
            new Evaluation { DA="0123456", Description="Examen mi-session", Note=82},
            new Evaluation { DA="0123456", Description="Examen final", Note=80},
            new Evaluation { DA="7654321", Description="TP1", Note=88},
            new Evaluation { DA="7654321", Description="TP2", Note=94},
            new Evaluation { DA="7654321", Description="TP3", Note=65},
            new Evaluation { DA="7654321", Description="Examen mi-session", Note=91},
            new Evaluation { DA="7654321", Description="Examen final", Note=75},
            new Evaluation { DA="0981321", Description="TP1", Note=97},
            new Evaluation { DA="0981321", Description="TP2", Note=92},
            new Evaluation { DA="0981321", Description="TP3", Note=81},
            new Evaluation { DA="0981321", Description="Examen mi-session", Note=60},
            new Evaluation { DA="0981321", Description="Examen final", Note=78},
            new Evaluation { DA="1234567", Description="TP1", Note=75},
            new Evaluation { DA="1234567", Description="TP2", Note=84},
            new Evaluation { DA="1234567", Description="TP3", Note=91},
            new Evaluation { DA="1234567", Description="Examen mi-session", Note=39},
            new Evaluation { DA="1234567", Description="Examen final", Note=62},
            #endregion
        };
    }
}
