using _05_TodoList.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TodoList.Repository.Handlers
{
    public class TodoHandler
    {
        public List<TodoItem> TodoItems { get; private set; } = new List<TodoItem>();

        public TodoItem Create(string title)
        {
            return new TodoItem { Title = title };
        }

        public void AddToList(TodoItem item)
        {
            TodoItems.Add(item);
        }
    }
}
