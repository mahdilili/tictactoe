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
using ExercicesLib;

namespace CryptageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        private STHCryptage _crypteur = new STHCryptage();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTraiter_Click(object sender, RoutedEventArgs e)
        {
            if (optEncrypter.IsChecked == true)
                txtDestination.Text = _crypteur.Encrypter(txtSource.Text);
            else
                txtDestination.Text = _crypteur.Décrypter(txtSource.Text);

        }
    }
}
