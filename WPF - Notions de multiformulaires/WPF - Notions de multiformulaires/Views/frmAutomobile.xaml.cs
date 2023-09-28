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
using InventaireAutomobiles.Models;
using InventaireAutomobiles.Views;

namespace InventaireAutomobiles.Views
{
    /// <summary>
    /// Logique d'interaction pour frmAutomobile.xaml
    /// </summary>
    public partial class frmAutomobile : Window
    {
        #region Champs

        private Automobile _auto_originale = new Automobile();
        private Automobile _auto_édition = null;
        #endregion
        public frmAutomobile()
        {
            InitializeComponent();
            grdMain.DataContext = _auto_originale; 
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void frmAuto_Loaded(object sender, RoutedEventArgs e)
        {
            
            _auto_édition = ((Automobile)grdMain.DataContext).Cloner();
            grdMain.DataContext = _auto_édition;
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            grdMain.DataContext = _auto_originale;
            DialogResult = false;
        }
    }
}
