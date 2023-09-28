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
        public static List<Etudiant> _etudiants = new List<Etudiant>()
        {
            new Etudiant { Prenom = "Svetlana", Nom = "Omelchenko",  Notes = new List<int> { 97, 92, 81, 60, 78 } },
            new Etudiant { Prenom = "Claire",   Nom = "O’Donnell",   Notes = new List<int> { 75, 84, 91, 39, 62 } },
            new Etudiant { Prenom = "Sven",     Nom = "Mortensen",   Notes = new List<int> { 88, 94, 65, 91, 75 } },
            new Etudiant { Prenom = "Cesar",    Nom = "Garcia",      Notes = new List<int> { 97, 89, 85, 82, 80 } },
            new Etudiant { Prenom = "Debra",    Nom = "Garcia",      Notes = new List<int> { 35, 72, 91, 70, 60 } },
            new Etudiant { Prenom = "Fadi",     Nom = "Fakhouri",    Notes = new List<int> { 99, 86, 90, 94, 84 } },
            new Etudiant { Prenom = "Hanying",  Nom = "Feng",        Notes = new List<int> { 93, 92, 80, 87, 76 } },
            new Etudiant { Prenom = "Hugo",     Nom = "Garcia",      Notes = new List<int> { 92, 90, 83, 78, 68 } },
            new Etudiant { Prenom = "Lance",    Nom = "Tucker",      Notes = new List<int> { 68, 79, 88, 92, 80 } },
            new Etudiant { Prenom = "Terry",    Nom = "Adams",       Notes = new List<int> { 99, 82, 81, 79, 84 } },
            new Etudiant { Prenom = "Eugene",   Nom = "Zabokritski", Notes = new List<int> { 96, 85, 91, 60, 66 } },
            new Etudiant { Prenom = "Michael",  Nom = "Tucker",      Notes = new List<int> { 94, 92, 91, 91, 90 } },
            new Etudiant { Prenom = "Karen",    Nom = "Feng",        Notes = new List<int> { 67, 78, 80, 90, 81 } }
        };
    }
}
