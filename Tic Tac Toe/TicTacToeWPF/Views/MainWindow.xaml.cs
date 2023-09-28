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
using TicTacToeLib;
using TicTacToeWPF.Views;

namespace TicTacToeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constantes
        const string URI = "pack://application:,,,/Images/";
        #endregion

        #region Champs
        private TicTacToeLogique _jeu = new TicTacToeLogique();
        private Label[,] _planche = new Label [3,3];
        #endregion
        #region Méthodes
        private void RemplirTableauPlanche()
        {
            //Variables locales
            int iColonne = 0;
            int iLigne = 0;

            for (int iPos = 0; iPos < grdPlanche.Children.Count; iPos++)
            {
                iLigne = Grid.GetRow(grdPlanche.Children[iPos]);
                iColonne = Grid.GetColumn(grdPlanche.Children[iPos]);
                _planche[iLigne, iColonne] =(Label)grdPlanche.Children[iPos];
            }
        }

        private void ViderPlanche()
        {
            for (int iLigne = 0; iLigne < _planche.GetLength(0); iLigne++)
            {
                for (int iColonne = 0; iColonne < _planche.GetLength(1); iColonne++)
                {
                    _planche[iLigne, iColonne].Content= "";
                    _planche[iLigne, iColonne].Background = JetonToImage(TicTacToeLogique.Jetons.Vide);

                }
            }
        }

        private Brush JetonToImage(TicTacToeLogique.Jetons jeton)
        {
            //Variables locales

            Brush img = null;
            switch(jeton)
            {
                case TicTacToeLogique.Jetons.Vide:
                    img = Brushes.Transparent;
                    break;
                case TicTacToeLogique.Jetons.X:
                    img = new ImageBrush(new BitmapImage(new Uri(URI + "X.png")));
                    break;
                case TicTacToeLogique.Jetons.O:
                    img = new ImageBrush(new BitmapImage(new Uri(URI + "O.png")));
                    break;
                default:
                    break;
            }
              
            return img; 
        }
        private void AfficherJeton(Label composante, TicTacToeLogique.Jetons jeton)
        {
            if (chkImages.IsChecked == false)
                composante.Content = jeton;
            else
                composante.Background = JetonToImage(jeton);
        }
        private void Redémarrer()
        {
            _jeu.RénitialiserPartie();  //Grille interne du jeu (Non visuelle)
            ViderPlanche();   // Grille visuelle du jeu
            grdPlanche.IsEnabled = true;
            btnDémarrer.Content = "Recommencer";
        }
        #endregion
        #region Constructeurs

        public MainWindow()
        {
            InitializeComponent();
            RemplirTableauPlanche();
        }
        #endregion
        #region Evénements

        private void btnDémarrer_Click(object sender, RoutedEventArgs e)
        {
            _jeu.RénitialiserPartie();  //Grille interne du jeu (Non visuelle)
            ViderPlanche();   // Grille visuelle du jeu
            grdPlanche.IsEnabled = true;
            btnDémarrer.Content = "Recommencer";
        }

        private void grdPlanche_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Variables locales
            int iLigne = 0;
            int iColonne = 0;
            TicTacToeLogique.Jetons JetonPrécédent = _jeu.JetonCourant;
            //e.Source
            Label composante = e.Source as Label;  // équivalent d'un casting (Label)e.Source
                                                   // Si succès retourne la référence sur l'objet 
                                                   // Si non succès retource null;


            if (composante != null)
            {
                //MessageBox.Show(((Label)(e.Source)).Name);
                //On peut remplacer la ligne précédente avec celle ci 
                // MessageBox.Show(composante.Name);
                iLigne = Grid.GetRow(composante);
                iColonne = Grid.GetColumn(composante);


                switch(_jeu.Déposer(iLigne+1,iColonne+1))
                {
                    case TicTacToeLogique.état.MauvaiseCoordonnées:
                        break;
                    case TicTacToeLogique.état.NonVide:
                        MessageBox.Show("Case non vide!","ERREUR",MessageBoxButton.OK,MessageBoxImage.Error);
                        break;
                    case TicTacToeLogique.état.DépotRéussi:
                        AfficherJeton(composante, JetonPrécédent);
                        break;
                    case TicTacToeLogique.état.Gagnant:
                        AfficherJeton(composante, JetonPrécédent);
                        MessageBox.Show("Les "+_jeu.JetonCourant+" sont les gagants!!!","Bravo", MessageBoxButton.OK, MessageBoxImage.Information);
                        grdPlanche.IsEnabled = false; // Désactiver la planche 
                        break;
                    case TicTacToeLogique.état.PartieNulle:
                        AfficherJeton(composante, JetonPrécédent);
                        MessageBox.Show("La partie est nulle ", "Egalité!", MessageBoxButton.OK, MessageBoxImage.Information);
                        grdPlanche.IsEnabled = false; // Désactiver la planche 
                        break;
                    default:
                        break;
                }
                                    
                                    
            }   
        }
        #endregion

        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            //Variables locales
            bool bchange = _jeu.Options.JetonDéfautO;
            frmOptions frm = new frmOptions();

            frm.Owner = this;
            frm.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            frm.grdMain.DataContext = _jeu.Options;
            frm.ShowDialog();

            if (_jeu.Options.JetonDéfautO)
            {
                _jeu.ChangerJetonDépart(TicTacToeLogique.Jetons.O);
            }
            else
                _jeu.ChangerJetonDépart(TicTacToeLogique.Jetons.X);

            if (bchange != _jeu.Options.JetonDéfautO)
            Redémarrer();
            
        }

    }
}
