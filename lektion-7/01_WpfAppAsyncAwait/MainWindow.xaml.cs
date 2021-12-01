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

namespace _01_WpfAppAsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string result;

        public MainWindow()
        {
            InitializeComponent();
            Timer();

            Task.Run(GetDataAsync);
        }

        private void btnSync_Click(object sender, RoutedEventArgs e)
        {
            result += BlockingCode.Step1();
        }

        private async void btnAsync_Click(object sender, RoutedEventArgs e)
        {
            await GetDataAsync();
        }

        private void tblockClear_MouseUp(object sender, MouseButtonEventArgs e)
        {
            result = "";
            tblockResult.Text = "";       
        }

        private async Task GetDataAsync()
        {
            result += await NonBlockingCode.Step1();
        }


        private void Timer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            tblockResult.Text = result;
        }

    }
}
