using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TodoList.Repository.Models
{
    public class TodoItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public bool IsCompleted { get; private set; } = false;
    }
}
