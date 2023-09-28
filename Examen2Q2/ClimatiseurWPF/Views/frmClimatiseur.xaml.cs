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
using System.Windows.Shapes;
using ClimatiseurWPF.Models;
namespace ClimatiseurWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour frmClimatiseur.xaml
    /// </summary>
    public partial class frmClimatiseur : Window
    {
        #region Champs
        private Climatiseur Climatiseur_initial = new Climatiseur();
        #endregion
        public frmClimatiseur()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            frmClim.DataContext = Climatiseur_initial;
            DialogResult = false;
        }
    }
}
