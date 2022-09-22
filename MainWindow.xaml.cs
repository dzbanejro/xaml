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

namespace Projekt1
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
            btnStart.Background.Opacity = 0.5;
            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Witaj, świecie!");
            btnStart.Visibility = Visibility.Visible;
            btnStart.Background.Opacity = 1;
            

        }

        private bool isClicked = false;
        private void btnActive_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;

            if (isClicked)
            {
                btnStart.IsEnabled = false;
                isClicked = false;
            }
            else isClicked = true;
 
    }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }
    }
}
