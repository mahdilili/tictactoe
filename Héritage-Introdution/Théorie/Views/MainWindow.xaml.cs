using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Théorie.Models.Ecole;
using Théorie.Models.Formes;

namespace Théorie
{
    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Ce programme va servir à la présente théorie.
    /// Date: 2020-03-19
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        private List<Personne> _liste = new List<Personne>();
        #endregion
        /// <summary>
        /// Auteur: Martin Lalancette
        /// Description: Constructeur servant à initialiser les composantes visuelles
        ///              se trouvant dans la fenêtre principale de l'application.
        /// Date: 2020-03-19
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Initialiser la liste avec des intervenants.
            _liste.Add(new Etudiant()
            {
                Nom = "Savard",
                Prénom = "Line"
            });
            _liste.Add(new Professeur()
            {
                Nom = "Couture",
                Prénom = "Jade"
            });
            _liste.Add(new Etudiant()
            {
                Nom = "Serge",
                Prénom = "Roy"
            });
            _liste.Add(new Directeur()
            {
                Nom = "Fortin",
                Prénom = "Carl"
            });
            _liste.Add(new Etudiant()
            {
                Nom = "Tremblay",
                Prénom = "Marc"
            });
            _liste.Add(new Professeur()
            {
                Nom = "Boulay",
                Prénom = "Simon"
            });
        }

        private void btnExercice01_Click(object sender, RoutedEventArgs e)
        {
            Etudiant e1 = new Etudiant();
            Professeur p1 = new Professeur();
            Directeur d1 = new Directeur();
            Personne p3 = new Etudiant();
            
            Personne pers1 = new Personne();
            Personne p2 = new Personne("Carl", "Roy", 45);
            Etudiant e2 = new Etudiant("Mahdi", "Ellili", 22);


            //Ajouter une voiture pour le directeur
            d1.Enregistrer(new Voiture() { 
            Active=true,
            DateDébut = DateTime.Now,
            NbKmParcourus = 0
            });
            txtRésultat.Clear();
            txtRésultat.AppendText("Etudiant: " + e1.ObtenirRole() + "\r\n");
            txtRésultat.AppendText("Professeur: " + p1.ObtenirRole() + "\r\n");
            txtRésultat.AppendText("Directeur: " + d1.ObtenirRole() + "\r\n");
            

        }

        private void btnExercice2_Click(object sender, RoutedEventArgs e)
        {
            var req = from personne in _liste
                      group personne by personne.GetType() into grp
                      select new
                      {
                          Catégorie = grp.Key,
                          Personnes = grp
                      };
            txtRésultat.Clear();
            foreach (var grp in req)
            {
                txtRésultat.AppendText(grp.Catégorie + ": \r\n");
                foreach (Personne personne in grp.Personnes)
                {
                    txtRésultat.AppendText("\t" + personne.ObtenirRole() + "\r\n");
                }
            }
        }

        private void btnExercice08_10_Click(object sender, RoutedEventArgs e)
        {
         //   Forme f = new Forme();  // Impossible à créer car c'est une classe abstraite
            Carré carré = new Carré()
            {
                Coté = 5,
                PositionX = 100,
                PositionY = 200,
                CouleurFond = Brushes.Red

            };
            txtRésultat.AppendText("Carré: " + carré.Aire + " Périmètre: "+carré.Périmètre);
            
        }
    }
}

