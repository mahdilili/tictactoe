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
using ClimatiseurWPF.Models;
using ClimatiseurWPF.Views;
namespace ClimatiseurWPF
{
    /// <summary>
    /// Auteur: Mahdi Ellili 
    /// Description : Programme qui sert à entrer les informations d'un climatiseur
    /// Date: 2022-04-20
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        Climatiseur climatiseur = new Climatiseur();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        

        }

        private void btnRemplir_Click(object sender, RoutedEventArgs e)
        {

            //Variables locales

            
            
            frmClimatiseur clim = new frmClimatiseur();

            clim.Owner = this;
            clim.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            bool? bRetour = clim.ShowDialog();

            if (bRetour == true)
            {
                 climatiseur= (Climatiseur)clim.frmClim.DataContext;

            }            

        }

        private void btnAfficher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(climatiseur.Description,"Informations",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
