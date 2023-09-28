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

namespace GestionImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constantes
        const string _URI = "pack://application:,,,/Images/";
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnChangerRectangle_Click(object sender, RoutedEventArgs e)
        {
            rctImage.Fill = new ImageBrush(new BitmapImage(new Uri(_URI + "carré1.png")));
        }

        private void btnChangerEllipse_Click(object sender, RoutedEventArgs e)
        {
            eliImage.Fill = new ImageBrush(new BitmapImage(new Uri(_URI + "carré2.png")));
        }

        private void btnChangerImage_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Source=new BitmapImage(new Uri(_URI+"carré2.png"));
        }

        private void btnChangerlabel_Click(object sender, RoutedEventArgs e)
        {
            lblImage.Background= new ImageBrush(new BitmapImage(new Uri(_URI + "carré1.png")));
        }
    }
}
