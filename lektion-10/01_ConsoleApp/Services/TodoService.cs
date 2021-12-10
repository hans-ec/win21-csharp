using _01_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApp.Services
{
    public class TodoService
    {
        public List<Todo> Todos { get; private set; } = new List<Todo>();

        public Todo CreateTodo(string title)
        {
            Todo todo = new Todo { Id = Guid.NewGuid(), Title = title };
            return todo;
        }

        public void AddToList(Todo todo)
        {
            Todos.Add(todo);
        }

        public void RemoveFromList(Todo todo)
        {
            Todos = Todos.Where(x => x.Id != todo.Id).ToList();

            //var index = Todos.IndexOf(todo);
            //Todos.RemoveAt(index);
        }
    }
}
