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
    /// Date: 2016-02-23
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Auteur: Martin Lalancette
        /// Description: Constructeur servant à initialiser les composantes visuelles
        ///              se trouvant dans la fenêtre principale de l'application.
        /// Date: 2016-01-12
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExercice02_Click(object sender, RoutedEventArgs e)
        {
            var req = from employé in _employes
                      group employé by employé.Division into GrpDivision
                      orderby GrpDivision.Key.ToString() descending
                      select new
                      {
                          Division = GrpDivision.Key,
                          Employés = GrpDivision
                      };
            foreach (var groupe in req)
            {
                txtRésultat.AppendText("Division: " + groupe.Division + "\n");
                foreach (var emp in groupe.Employés)
               
                    txtRésultat.AppendText("Employés" + emp + "\r\n");
                
            }
        }

        private void btnExercice05_Click(object sender, RoutedEventArgs e)
        {
            var req =
                from Achat in _achats
                join Article in _articles
                on Achat.NoArticle equals Article.NoArticle
                select new
                {
                    NoVente= Achat.NoVente,
                    Nom = Article.Nom,
                    Prix = Article.Prix,
                    Quantité = Achat.Quantite,
                    Total = Article.Prix * Achat.Quantite
                };
            foreach (var item in req)
            {
                txtRésultat.AppendText("Vente: "+item.NoVente+", Article: " + item.Nom + ", Prix: " + item.Prix + "$, Qté: " + item.Quantité + ", Total: " + item.Total+"\r\n");
            }

        }

        private void btnExercice08_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            int iNb = _nombres.Count(nombre => nombre >= 20 && nombre <= 80);
            txtRésultat.Text = iNb.ToString();

        }

        private void btnExercice09_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 
            int iNb = _nombres.Count(nombre => Math.Pow(nombre, 2) %3 == 0);
            txtRésultat.Text = iNb.ToString();
        }

        private void btnExercice10_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            int iNb = _prenoms.Count(prenom => prenom.Length>=2 && char.ToLower(prenom[1])=='a');
            txtRésultat.Text = iNb.ToString();
        }

        private void btnExercice11_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales 
            int iNb = _mots.Count(mot => mot.Length > 3);
            txtRésultat.Text = iNb.ToString();
        }

        private void btnExercice12_Click(object sender, RoutedEventArgs e)
        {
            int iNb = _mots.Count(mot => mot.Count(car => car == 's') > 1);
            txtRésultat.Text = iNb.ToString();

        }

        private void btnExercice13_Click(object sender, RoutedEventArgs e)
        {
            int iNb = _etudiants.Count(etudiant => etudiant.CodeCours == "CAC" && etudiant.Nom == "Turcotte");
            txtRésultat.Text = iNb.ToString();
        }

        private void btnExercice14_Click(object sender, RoutedEventArgs e)
        {
            txtRésultat.Clear();
            txtRésultat.AppendText("Somme: " + _nombres.Sum()+ "\r\n ");
            txtRésultat.AppendText("Moyenne: " + _nombres.Average() + "\r\n ");
            txtRésultat.AppendText("Min: " + _nombres.Min() + "\r\n ");
            txtRésultat.AppendText("Max: " + _nombres.Max() + "\r\n ");
        }

        private void btnExercice15_Click(object sender, RoutedEventArgs e)
        {
            int filtre(string sMot) => sMot.Length;
            //txtRésultat.Clear();
            //txtRésultat.AppendText("Somme: " + _mots.Sum(mot => mot.Length) + "\r\n ");
            //txtRésultat.AppendText("Moyenne: " + _mots.Average(mot => mot.Length) + "\r\n ");
            //txtRésultat.AppendText("Min: " + _mots.Min(mot => mot.Length) + "\r\n ");
            //txtRésultat.AppendText("Max: " + _mots.Max(mot => mot.Length) + "\r\n ");

            txtRésultat.Clear();
            txtRésultat.AppendText("Somme: " + _mots.Sum(filtre) + "\r\n ");
            txtRésultat.AppendText("Moyenne: " + _mots.Average(filtre) + "\r\n ");
            txtRésultat.AppendText("Min: " + _mots.Min(filtre) + "\r\n ");
            txtRésultat.AppendText("Max: " + _mots.Max(filtre) + "\r\n ");
        }

        private void btnExercice16_Click(object sender, RoutedEventArgs e)
        {
            int filtre(Employe emp) => emp.Anciennete;
           

            txtRésultat.Clear();
            txtRésultat.AppendText("Somme: " + _employes.Sum(filtre) + "\r\n ");
            txtRésultat.AppendText("Moyenne: " + _employes.Average(filtre) + "\r\n ");
            txtRésultat.AppendText("Min: " + _employes.Min(filtre) + "\r\n ");
            txtRésultat.AppendText("Max: " + _employes.Max(filtre) + "\r\n ");
        }

        private void btnExercice17_Click(object sender, RoutedEventArgs e)
        {
            bool filtre(int iNombre) => iNombre >=100 ;


            txtRésultat.Clear();
            txtRésultat.AppendText("Première: " + _nombres.First(filtre) + "\r\n");
            txtRésultat.AppendText("Dernière: " + _nombres.Last(filtre) + "\r\n ");
            
        }

        private void btnExercice19_Click(object sender, RoutedEventArgs e)
        {
             bool filtre(Article article) => article.Nom.StartsWith("USB");
            Article articlepremier = _articles.First(filtre);
            Article articledernier = _articles.Last(filtre);

            txtRésultat.Clear();
            txtRésultat.AppendText("Première: " + articlepremier.Prix + "\r\n");
            txtRésultat.AppendText("Dernière: " + articledernier.Prix + "\r\n ");
        }

        private void btnExercice20_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales

            List<string> motsFiltrés = null;
            bool filtre(string mot) => mot.Length < 8 && 
                                       !mot.StartsWith("p",StringComparison.CurrentCultureIgnoreCase);
            motsFiltrés = _mots.Where(filtre).ToList();
            txtRésultat.Clear();
            foreach (string smot in motsFiltrés)
            {
                txtRésultat.AppendText(smot + "\r\n");
            }
        }

        private void btnExercice21_Click(object sender, RoutedEventArgs e)
        {
            List<Employe> employésFiltrés = null;
            bool filtre(Employe emp) => emp.Division == Employe.enumDivision.RVS || emp.NoSucc != "0002";

            employésFiltrés = _employes.Where(filtre).ToList();
            txtRésultat.Clear();
            foreach (Employe emp in employésFiltrés)
            {
                txtRésultat.AppendText(emp + "\r\n");
            }
        }

        private void btnExercice24_Click(object sender, RoutedEventArgs e)
        {
            Employe[] empFiltrés = null;

            bool filtre(Employe emp) => emp.Division == Employe.enumDivision.MTL;

            empFiltrés = _employes.Where(filtre)
                        .OrderByDescending(emp => emp.Anciennete)
                        .Take(2)
                        .ToArray();
            txtRésultat.Clear();
            foreach (Employe emp in empFiltrés)
            {
                txtRésultat.AppendText(emp. + "\r\n");
            }
        }
    }
}
