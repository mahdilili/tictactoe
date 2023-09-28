using SimpleEditeur.Views;
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
using SimpleEditeur.Models;
namespace SimpleEditeur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        frmOutils _outils = null;
        Styles _styles = new Styles();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Méthodes
        private void AppliquerStyles(Styles styles)
        {
            if (styles.Gras)
            {
                txtEditeur.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
            }
            else
                txtEditeur.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);

            if (styles.Italique)
            {
                txtEditeur.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
            }
            else
                txtEditeur.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);

            if(styles.Taille!=0)
            {
                txtEditeur.Selection.ApplyPropertyValue(Run.FontSizeProperty,(double)styles.Taille);
            }
            else
                txtEditeur.Selection.ApplyPropertyValue(Run.FontSizeProperty, 12d);
            switch (styles.Couleur)
            {
                case Styles.Couleurs.Blanc:
                    txtEditeur.Selection.ApplyPropertyValue(Run.ForegroundProperty, Brushes.White);
                    break;
                case Styles.Couleurs.Jaune:
                    txtEditeur.Selection.ApplyPropertyValue(Run.ForegroundProperty, Brushes.Yellow);
                    break;
                case Styles.Couleurs.Bleu:
                    txtEditeur.Selection.ApplyPropertyValue(Run.ForegroundProperty, Brushes.Blue);
                    break;
                case Styles.Couleurs.Noir:
                    txtEditeur.Selection.ApplyPropertyValue(Run.ForegroundProperty, Brushes.Black);
                    break;
                default:
                    break;
            }
        }
        #endregion
        private void btnOutils_Click(object sender, RoutedEventArgs e)
        {
            if (_outils == null) // Fenêtre non ouverte
            {
                _outils = new frmOutils();
                _outils.Owner = this;
                _outils.DataContext = _styles; // Pour pouvoir remplir le datacontext
                _outils.Closed += _outils_Closed;
                _outils.NotifierChangerStyles += _outils_NotifierChangerStyles;
                _outils.Show();  // Non modal donc non bloquant
            }
            else    // fenêtre déja ouverte
            {
                _outils.Focus();
            }
        }

        private void _outils_NotifierChangerStyles(object sender, Styles e)
        {
            AppliquerStyles(e);
        }

        private void _outils_Closed(object sender, EventArgs e)
        {
            _outils = null;
        }

        private void btnAppliquer_Click(object sender, RoutedEventArgs e)
        {
           // Styles styles = _outils.grdMain.DataContext as Styles;

            if (_styles != null)
            {
                //Appliquer les styles 
                AppliquerStyles(_styles);
            }
        }
    }
}
