using _00_Repetition.Models;
using _00_Repetition.Services;
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

namespace _00_Repetition
{
    enum State
    {
        Idle,
        Saving,
        Saved,
        SavedFailed,
        Removing,
        Removed,
        RemovedFailed
    }



    public partial class MainWindow : Window
    {
        private static State _state = State.Idle;

        public MainWindow()
        {
            InitializeComponent();
            StateTimer();
            Task.FromResult(GetTodosAsync());
        }

        private async Task GetTodosAsync()
        {
            lvTodos.ItemsSource = await TodoService.GetTodosAsync();
        }

        private void StateTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += state_timer_tick;
            timer.Start();
        }

        private void state_timer_tick(object sender, EventArgs e)
        {
            switch (_state)
            {
                case State.Idle:
                    tblockStatus.Text = "";
                    break;

                case State.Saving:
                    tblockStatus.Text = "Creating Todo Item";
                    break;

                case State.Saved:
                    tblockStatus.Text = "Todo item saved to Database.";
                    break;

                case State.SavedFailed:
                    tblockStatus.Text = "Error: Failed to save item to the Database.";
                    break;

                case State.Removing:
                    tblockStatus.Text = "Todo item is being removed.";
                    break;

                case State.Removed:
                    tblockStatus.Text = "Todo item removed from the Database.";
                    break;

                case State.RemovedFailed:
                    tblockStatus.Text = "Error: Failed to remove item from the Database.";
                    break;
            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            _state = State.Saving;
            _state = await TodoService.CreateTodoAsync(tbTitle.Text);
            tbTitle.Text = "";

            await GetTodosAsync();
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            _state = State.Removing;

            var obj = (Button)sender;
            var item = (TodoItem)obj.DataContext;

            _state = await TodoService.RemoveTodoAsync(item);
            await GetTodosAsync();
        }

    }
}
