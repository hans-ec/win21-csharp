using _02_TodoList.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TodoList.Repository.Handlers
{
    public class TodoHandler
    {
        public List<TodoItem> TodoItems { get; private set; } = new List<TodoItem>();

        public TodoItem CreateTodo(string title)
        {
            return new TodoItem { Title = title };
        }

        public void AddToList(TodoItem todo)
        {
            TodoItems.Add(todo);
        }

        public void RemoveFromList(Guid id)
        {
            TodoItems = TodoItems.Where(item => item.Id != id).ToList();
        }

        public void ToggleIsCompleted(TodoItem todo)
        {
            var item = TodoItems.Where(item => item.Id == todo.Id).FirstOrDefault();
            
            if(item != null)
                item.IsCompleted = !item.IsCompleted;

        }
    }
}
