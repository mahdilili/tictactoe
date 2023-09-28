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
using Théorie.Models.Commerce;

namespace Théorie.Views
{
    /// <summary>
    /// Auteur: Martin Lalancette
    /// Description: Ce programme va servir à la présentation des notions sur les objets - LINQ.
    /// Date: 2020-03-20
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Auteur: Martin Lalancette
        /// Description: Constructeur servant à initialiser les composantes visuelles
        ///              se trouvant dans la fenêtre principale de l'application.
        /// Date: 2020-03-20
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: à partir de la collection _nombres, va extraire les nombres plus grand ou égal  à 40.
        /// Date:2022-04-13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExercice02_Click(object sender, RoutedEventArgs e)
        {
            //variables locales 
            var req = from iNombre in _nombres
                      where iNombre >= 40
                      select iNombre;
            txtRésultat.Clear();

            foreach (int iNombre in req)
            {
                txtRésultat.AppendText(iNombre + "\r\n");  // AppendText accumule les informations dans un label et il ne fait pas un changement de ligne
            }
        }

        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: à partir de la collection _nombres, extraire les nombres se situant entre 75 et 125
        /// Date:2022-04-13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExercice03_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            var req = from iNumber in _nombres
                      where iNumber >= 75 && iNumber <= 125
                      select iNumber;

            txtRésultat.Clear();
            foreach (int iNumber in req)
            {
                txtRésultat.AppendText(iNumber + "\r\n");  // AppendText accumule les informations dans un label et il ne fait pas un changement de ligne
            }
        }

        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: à partir de la collection _nombres,  va extraire les nombres NE se situant PAS entre 80 et 120.
        /// Date:2022-04-13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExercice04_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            var req = from iNumber in _nombres
                      where iNumber <80  || iNumber > 120
                      // autre façon !(iNumber >= 80 && iNumber <= 125)
                      select iNumber;

            txtRésultat.Clear();
            foreach (int iNumber in req)
            {
                txtRésultat.AppendText(iNumber + "\r\n");  // AppendText accumule les informations dans un label et il ne fait pas un changement de ligne
            }
        }   


        /// <summary>
        /// Auteur:Mahdi Ellili
        /// Description: à partir de la collection _nombres,  va extraire les montants entre 1000 et 2000 ou bien entre 2500 et 3500.
        /// Date:2022-04-13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExercice05_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            var req = from dVente in _ventes
                      where (dVente >=1000 && dVente <= 2000) || (dVente >=2500 && dVente <=3000)
                      select dVente;

            txtRésultat.Clear();
            foreach (double dVente in req)
            {
                txtRésultat.AppendText(dVente.ToString("0.00 $") + "\r\n");  // AppendText accumule les informations dans un label et il ne fait pas un changement de ligne
            }
        }

        private void btnExercice06_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 


            var req = from employé in _employes
                      where employé.Division == Employe.enumDivision.MTL
                      select employé;

            foreach (Employe emp in req)
            {
                txtRésultat.AppendText(emp.Nom+ " " + emp.Prenom + "\r\n");
            }
        }

        private void btnExercice07_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 


            var req = from employé in _employes
                      where employé.Division == Employe.enumDivision.MTL
                      select employé;

            foreach (Employe emp in req)
            {
                txtRésultat.AppendText(emp +  "\r\n");
            }
        }

        private void btnExercice08_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 


            var req = from employé in _employes
                      where employé.Division != Employe.enumDivision.RVS && employé.Anciennete > 10
                      select employé;

            foreach (Employe emp in req)
            {
                txtRésultat.AppendText(emp + "\r\n");
            }
        }

        private void btnExercice09_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            var req = from iNumber in _nombres
                      where iNumber >= _nombres.Average()
                      orderby iNumber descending
                      select iNumber;

            txtRésultat.Clear();
            txtRésultat.AppendText("Moyenne: " + _nombres.Average()+"\r\n");
            foreach (int iNumber in req)
            {
                txtRésultat.AppendText(iNumber + "\r\n");  // AppendText accumule les informations dans un label et il ne fait pas un changement de ligne
            }
        }

        private void btnExercice10_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 


            var req = from sPrénom in _prenoms
                      orderby sPrénom.Length ascending
                      select sPrénom;

            foreach (string prénom in req)
            {
                txtRésultat.AppendText(prénom +", L: "+prénom.Length+"\r\n");
            }
        }

        private void btnExercice11_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            txtRésultat.Clear();
            var req = from employé in _employes
                      where (DateTime.Now.Year -employé.Naissance.Year) >= 30 && 
                      (employé.Division == Employe.enumDivision.MTL || 
                      employé.Division == Employe.enumDivision.RVS ) || 
                      employé.Anciennete < 10 && employé.Division == Employe.enumDivision.RVN
                      orderby employé.Nom, employé.Naissance
                      select employé;
            foreach (Employe emp in req)
            {
                txtRésultat.AppendText(emp + "\r\n");
            }

        }

        private void btnExercice12_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales

            var req = from employé in _employes
                      where employé.Division == Employe.enumDivision.RVN
                      select new { 
                          employé.Nom, 
                          employé.Prenom, 
                          No = employé.NoEmp }; // Clasee anonyme

            foreach (var emp in req)
            {
                txtRésultat.AppendText(emp.Nom +" "+emp.Prenom+" "+emp.No+ "\r\n");
            }

        }

        private void btnExercice13_Click(object sender, RoutedEventArgs e)
        {
            var req = from etudiant in _etudiants
                      from note in etudiant.Notes

                      where note > 92
                      orderby etudiant.Nom, etudiant.Prenom
                      select new
                      {
                          etudiant.Nom,
                          etudiant.Prenom
                      };
            req = req.Distinct();
            txtRésultat.Clear();

            foreach (var etu in req)
            {
                txtRésultat.AppendText("Etudiant: " + etu.Nom + 
                                        " " + etu.Prenom+"\r\n");
            }


        }

        private void btnExercice14_Click(object sender, RoutedEventArgs e)
        {
            var req = from patient in _patients
                      from remarque in patient.Remarques
                      where remarque.Contains("vaccin H1N1",StringComparison.CurrentCultureIgnoreCase)
                      select new
                      {
                          patient.Nom,
                          patient.Prenom,
                          patient.NAM,
                          patient.Visites
                      };
            
            foreach (var pat in req)
            {
                txtRésultat.AppendText("Patient: " + pat.Prenom +
                                       " " + pat.Nom + " " +
                                       pat.NAM + "\r\n");
                foreach (var visite in pat.Visites)
                {
                    txtRésultat.AppendText("Date de visite: " + visite.ToShortDateString()+ "\r\n");
                }
            }
        }

        private void btnExercice16_Click(object sender, RoutedEventArgs e)
        {
            var req = from etudiant in _etudiants
                      let minimale = etudiant.Notes.Min()
                      let maximale = etudiant.Notes.Max()
                      let écart = maximale - minimale
                      where écart > 30
                      select new
                      {
                          etudiant.Nom,
                          etudiant.Prenom,
                          maximale,
                          minimale,
                          écart

                      };
            foreach (var etu in req)
            {
                txtRésultat.AppendText("Etudiant: " + etu.Nom + " " + etu.Prenom + ", Min: " + etu.minimale + ", Max: " + etu.maximale+", écart: "+etu.écart +"\r\n");
            }
        }

        private void btnExercice20_Click(object sender, RoutedEventArgs e)
        {
            var req = from emp in _employes
                      orderby emp.Anciennete descending
                      select new
                      {
                          emp.Nom,
                          emp.Prenom,
                          emp.Division,
                          emp.Anciennete
                      };
             req = req.Take(5);

            txtRésultat.Clear();
            foreach (var emp in req)
            {
                txtRésultat.AppendText($"Nom: {emp.Nom}, Prénom: {emp.Prenom}, Division: {emp.Division}, Anc. : {emp.Anciennete} \r\n");
            }
        }
    }
}
