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

namespace ButtonPracice01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ToggleColor = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn3DRound_Click(object sender, RoutedEventArgs e)
        {

            ChangeBarColor();
        }

        private void ChangeBarColor()
        {
            ToggleColor = !ToggleColor;

            if (ToggleColor)
            {
                Col0.Background = new SolidColorBrush(Colors.Yellow);
                Col1.Background = new SolidColorBrush(Colors.Brown);
                Col2.Background = new SolidColorBrush(Colors.Yellow);
                Col3.Background = new SolidColorBrush(Colors.Brown);
            }
            else
            {
                Col0.Background = new SolidColorBrush(Colors.Brown);
                Col1.Background = new SolidColorBrush(Colors.Yellow);
                Col2.Background = new SolidColorBrush(Colors.Brown);
                Col3.Background = new SolidColorBrush(Colors.Yellow);

            }

        }

        private void BtnBorderColor_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }

        private void BtnBackGroundColor_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }

        private void BtnLightColor_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }

        private void BtnDarkColor_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Blue);
            TbToogleInfo.Text = @"Clicked Start button";
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Red);
            TbToogleInfo.Text = @"Clicked Stop button";
        }

        private void BtnON_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Blue);
            TbToogleInfo.Text = @"Clicked ON";
        }

        private void BtnOFF_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Red);
            TbToogleInfo.Text = @"Clicked OFF";
        }


        private void BtnOnImag_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Green);
            TbToogleInfo.Text = @"Clicked Image ON - Green";
        }

        private void BtnOffImag_Click(object sender, RoutedEventArgs e)
        {
            TbToogleInfo.Foreground = new SolidColorBrush(Colors.Red);
            TbToogleInfo.Text = @"Clicked Image OFF - Red";
        }

        private void BtnImgage_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }

        private void BtnMultipleLines_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarColor();
        }
    }
}
