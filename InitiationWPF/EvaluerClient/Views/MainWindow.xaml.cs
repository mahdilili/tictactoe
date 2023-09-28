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
using EvaluerClient.Models;

namespace EvaluerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Enumérations

        #endregion
        #region Constantes

        #endregion
        #region Champs
        private Code _codeur = new Code();
        #endregion
        #region Proprietés

        #endregion
        #region Constructeurs


        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// 
        /// </summary>
        private void GénérerCode()
        {
            
            txtCode.Text = _codeur.CréerCodeSpécia(txtPrénom.Text, txtNom.Text, dateNaissance.SelectedDate);
        }
        #endregion

        #region Evénements

        private void btnRénitialiser_Click(object sender, RoutedEventArgs e)
        {
            txtNom.Text = "";
            //txtNom.Clear(); //autre façon 

            txtPrénom.Text = "";
            dateNaissance.SelectedDate = null;
           
        }

        private void btnAfficher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtPrénom.Text + " " + txtNom.Text, "Nom Complet!",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        #endregion

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            GénérerCode();
        }

        private void txtPrénom_TextChanged(object sender, TextChangedEventArgs e)
        {
            GénérerCode();
        }

        private void dateNaissance_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            GénérerCode();
        }
    }
}
