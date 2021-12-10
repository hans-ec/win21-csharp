using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TodoList.Repository.Models
{
    public class TodoItem
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public DateTimeOffset Created { get; } = DateTimeOffset.Now;
        public bool IsCompleted { get; set; } = false;
    }
}
