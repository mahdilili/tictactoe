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
using Théorie.Models;

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
        Random _rnd = new Random();
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
        }

        private void btnExercice01_Click(object sender, RoutedEventArgs e)
        {
            int iSomme = 0;

            iSomme = STHMath.Additionner(4, 10);
            txtRésultat.Text = iSomme.ToString();
        }

        private void btnExercice02_Click(object sender, RoutedEventArgs e)
        {
            txtRésultat.Clear();
            txtRésultat.AppendText("Celsius: " + Température.ConvertirEnCelsius(0)+"\r\n");
            txtRésultat.AppendText("Farenheit: " + Température.ConvertirEnFarhenheit(0));

            

        }

        private void btnExercice06_Click(object sender, RoutedEventArgs e)
        {
            int iValeur = 5;
            int iValeur2 = 8;
            txtRésultat.Text = iValeur.Tripler().ToString();
            iValeur2 = _rnd.Next(1, 11).Tripler();
        }

        private void btnExercice07_Click(object sender, RoutedEventArgs e)
        {


            txtRésultat.Text = txtChamp1.Text.Inverser();
        }

        private void btnExercice08_Click(object sender, RoutedEventArgs e)
        {
            txtRésultat.Text = txtChamp1.Text.Répéter(3);
        }
    }
}
