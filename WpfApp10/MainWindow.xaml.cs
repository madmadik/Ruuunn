using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Run(object sender,EventArgs e)
        {
            Random randomize = new Random();
            int winW = (int)this.Width;
            int winH = (int)this.Height;
            int butW = (int)button.Width;
            int butH = (int)button.Height;
            int randX = randomize.Next(winW - butW);
            int randY = randomize.Next(winH - butH);
       
            button.Margin = new Thickness(randX, randY, butW, butH);

        }
        private void Click_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ты выиграл!!!");
        }
    }
}
