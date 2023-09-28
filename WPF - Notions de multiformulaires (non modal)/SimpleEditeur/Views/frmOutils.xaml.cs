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
using SimpleEditeur.Models;
namespace SimpleEditeur.Views
{
    /// <summary>
    /// Logique d'interaction pour frmOutils.xaml
    /// </summary>
    public partial class frmOutils : Window
    {
        #region Champs

        #endregion
        #region Constructeur
        public frmOutils()
        {
            InitializeComponent();
            
            cmbCouleur.ItemsSource = Enum.GetNames(typeof(Styles.Couleurs));

        }
        #endregion
        #region Méthodes

        #endregion
        #region Evénements personnalisés 
        public event EventHandler<Styles> NotifierChangerStyles;
        #endregion

        #region Evénements

        #endregion

        private void chkGras_Checked(object sender, RoutedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);
        }

        private void chkGras_Unchecked(object sender, RoutedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);

        }

        private void chkItalique_Checked(object sender, RoutedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);

        }

        private void chkItalique_Unchecked(object sender, RoutedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);

        }

        private void txtTaille_TextChanged(object sender, TextChangedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);

        }

        private void cmbCouleur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NotifierChangerStyles?.Invoke(this, grdMain.DataContext as Styles);

        }
    }
}
