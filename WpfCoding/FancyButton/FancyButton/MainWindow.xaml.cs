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

namespace FancyButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer ButtonNoticeTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            ButtonNoticeTimer.Interval = new TimeSpan(0, 0, 0, 0, 3000);  // start after 3 sec
            ButtonNoticeTimer.Tick += ButtonNotice_Tick;
            ButtonNoticeTimer.Start();
        }

        public void ButtonNotice_Tick(object sender, EventArgs e)
        {
            // hiden button notice
            Tb_3dGradient.Visibility = Visibility.Hidden;
            Tb_3dFancy.Visibility = Visibility.Hidden;

            ButtonNoticeTimer.Stop();
        }

        private void Bt3DGradient_Click(object sender, RoutedEventArgs e)
        {
            Tb_3dGradient.Visibility = Visibility.Visible;
            ButtonNoticeTimer.Start();
        }

        private void BtFancy_Click(object sender, RoutedEventArgs e)
        {
            Tb_3dFancy.Visibility = Visibility.Visible;
            ButtonNoticeTimer.Start();
        }
    }
}
