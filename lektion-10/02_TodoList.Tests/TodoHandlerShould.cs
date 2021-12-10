using _02_TodoList.Repository.Handlers;
using _02_TodoList.Repository.Models;
using System.Linq;
using Xunit;

namespace _02_TodoList.Tests
{
    public class TodoHandlerShould
    {
        [Fact]
        public void Create_Todo()
        {
            // Arrange
            TodoHandler sut = new TodoHandler();

            // Action
            TodoItem todo = sut.CreateTodo("Todo Title");

            // Assert
            Assert.NotNull(todo);
        }

        [Fact]
        public void Add_Todo_To_List()
        {
            // Arrange
            TodoHandler sut = new TodoHandler();
            TodoItem todo = sut.CreateTodo("Todo Title");

            // Action
            sut.AddToList(todo);

            // Assert
            Assert.True(sut.TodoItems.Any());
        }

        [Fact]
        public void Remove_Todo_From_List()
        {
            // Arrange
            TodoHandler sut = new TodoHandler();
            TodoItem todo = sut.CreateTodo("Todo Title");
            sut.AddToList(todo);

            // Action
            sut.RemoveFromList(todo.Id);

            // Assert
            Assert.False(sut.TodoItems.Any());
        }

        [Fact]
        public void Toggle_Todo_IsCompleted()
        {
            // Arrange
            TodoHandler sut = new TodoHandler();
            TodoItem todo = sut.CreateTodo("Todo Title");
            sut.AddToList(todo);

            // Action
            sut.ToggleIsCompleted(todo);

            // Assert
            var item = sut.TodoItems.Where(item => item.Id == todo.Id).FirstOrDefault();
            Assert.True(item.IsCompleted);

        }
    }
}