using _02_UWP_TodoApp.Models;
using _02_UWP_TodoApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _02_UWP_TodoApp
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

    public sealed partial class MainPage : Page
    {
        private static State _state = State.Idle;

        public MainPage()
        {
            this.InitializeComponent();
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

        private void state_timer_tick(object sender, object e)
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
