using _01_WinForms_TodoApp.Models;
using _01_WinForms_TodoApp.Services;

namespace _01_WinForms_TodoApp
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

    public partial class Form1 : Form
    {
        private static State _state = State.Idle;

        public Form1()
        {
            InitializeComponent();
            StateTimer();
            Task.FromResult(GetTodosAsync());
        }


        private async Task GetTodosAsync()
        {
            var items = await TodoService.GetTodosAsync();
            lvTodos.Items.Clear();

            foreach (var item in items)
            {
                lvTodos.Items.Add(item.Title);
            }
                
        }

        private void StateTimer()
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(state_timer_tick);
            timer.Start();
        }

        private void state_timer_tick(object sender, EventArgs e)
        {
            switch (_state)
            {
                case State.Idle:
                    lbStatus.Text = "";
                    break;

                case State.Saving:
                    lbStatus.Text = "Creating Todo Item";
                    break;

                case State.Saved:
                    lbStatus.Text = "Todo item saved to Database.";
                    break;

                case State.SavedFailed:
                    lbStatus.Text = "Error: Failed to save item to the Database.";
                    break;

                case State.Removing:
                    lbStatus.Text = "Todo item is being removed.";
                    break;

                case State.Removed:
                    lbStatus.Text = "Todo item removed from the Database.";
                    break;

                case State.RemovedFailed:
                    lbStatus.Text = "Error: Failed to remove item from the Database.";
                    break;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            _state = State.Saving;
            _state = await TodoService.CreateTodoAsync(tbTitle.Text);
            tbTitle.Text = "";

            await GetTodosAsync();
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            _state = State.Removing;
            _state = await TodoService.RemoveTodoAsync(lvTodos.SelectedItem.ToString());
            await GetTodosAsync();
        }
    }
}