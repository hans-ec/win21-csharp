using _02_WpfTodoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace _02_WpfTodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient http = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            Task.FromResult(GetTodosAsync());
        }

        private async Task GetTodosAsync()
        {
            var items = await http.GetFromJsonAsync<IEnumerable<TodoItem>>("https://win21-demo.azurewebsites.net/api/GetTodos");
            lvTodos.Items.Clear();

            foreach (var item in items)
                lvTodos.Items.Add(item);
        }


        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbTitle.Text))
            {
                var item = new TodoItem { Id = Guid.NewGuid(), Title = tbTitle.Text };
                tbTitle.Text = "";

                var res = await http.PostAsJsonAsync("https://win21-demo.azurewebsites.net/api/SaveTodo", item);
                if (res.IsSuccessStatusCode)
                    lvTodos.Items.Add(item);
            }

            /*
                JS - fetch
                ----------------------------------------------------------------------
                fetch("https://win21-demo.azurewebsites.net/api/SaveTodo", {
                    method: 'post',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(item)
                }     
            */
        }

        private async void btnDelete_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var obj = (TextBlock)sender;
                var item = (TodoItem)obj.DataContext;

                var res = await http.PostAsJsonAsync($"https://win21-demo.azurewebsites.net/api/DeleteTodo?id={item.Id}", item);
                if(res.IsSuccessStatusCode)
                    lvTodos.Items.Remove(item);
            }
            catch { }
        }
    }
}
