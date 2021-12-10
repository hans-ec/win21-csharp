using _05_TodoList.Repository.Handlers;
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

namespace _05_TodoList.AppGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TodoHandler todoHandler = new TodoHandler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var item = todoHandler.Create(tbTitle.Text);
            todoHandler.AddToList(item);
            GetTodoItems();
            tbTitle.Text = "";
        }

        private void GetTodoItems()
        {
            lvTodoItems.Items.Clear();
            foreach(var item in todoHandler.TodoItems) 
                lvTodoItems.Items.Add(item);
        }
    }
}
