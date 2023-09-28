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
using System.Windows.Threading;

namespace Minuterie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        private DispatcherTimer _timer = new DispatcherTimer();
        int iTemps = 0;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            // Code à éxécuter
            iTemps++;
            lblTemps.Content = iTemps;
        }

        private void btnDémarrer_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }

        private void btnArrêter_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }
    }
}
