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

namespace ButtonProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            TbDemoNote.Text = "Clicked Button Star";
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            TbDemoNote.Text = "Clicked Button Up";
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            TbDemoNote.Text = "Clicked Button Down";
        }

        private void BtnCircle_Click(object sender, RoutedEventArgs e)
        {
            TbDemoNote.Text = "Clicked Button Circle";
        }

        private void BtnWall_Click(object sender, RoutedEventArgs e)
        {
            TbDemoNote.Text = "Clicked Button Wall";
        }
    }
}
