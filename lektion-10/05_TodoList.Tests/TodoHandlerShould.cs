using _05_TodoList.Repository.Handlers;
using _05_TodoList.Repository.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace _05_TodoList.Tests
{
    public class TodoHandlerShould
    {
        TodoHandler sut = new TodoHandler();

        [Fact]
        public void CreateTodo()
        {
            // Action
            TodoItem item = sut.Create("Todo Title");

            // Assert
            Assert.NotNull(item);
        }

        [Fact]
        public void AddToList()
        {
            // Arrange
            TodoItem item = sut.Create("Todo Title");
            
            // Action
            sut.AddToList(item);

            // Assert
            Assert.NotNull(item);
            Assert.True(sut.TodoItems.Any());
        }

        [Fact]
        public void GetTodoItems()
        {
            // Arrange
            TodoItem item = sut.Create("Todo Title");
            sut.AddToList(item);

            // Action
            IEnumerable<TodoItem> todoItems = sut.TodoItems;

            // Assert
            Assert.NotNull(todoItems);
        }
    }
}