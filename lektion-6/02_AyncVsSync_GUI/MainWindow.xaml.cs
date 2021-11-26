using _02_AyncVsSync_GUI.Accessories;
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

namespace _02_AyncVsSync_GUI
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

        private void BlockingBtn_Click(object sender, RoutedEventArgs e)
        {
            BlockingCode.MakeTacos();
            ResultWindow.Text += "Blocking Code Button Pressed";
        }

        private async void NonBlockingBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultWindow.Text += "Non-Blocking Code Button Pressed\n";
            ResultWindow.Text += await NonBlockingCode.MakeTacosAsync();
        }

    }
}
