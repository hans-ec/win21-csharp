using _01_ConsoleApp.Models;
using _01_ConsoleApp.Services;
using System.Linq;
using Xunit;

namespace _01_ConsoleApp.Tests
{
    public class TodoServiceShould
    {
        [Fact]
        public void Create_New_Todo()
        {
            // Arrange
            TodoService sut = new TodoService();
            string title = "Det här är min todo";

            // Action
            var todo = sut.CreateTodo(title);

            // Assert
            Assert.Equal(title, todo.Title);
        }

        [Fact]
        public void Add_Todo_To_List()
        {
            // Arrange
            TodoService sut = new TodoService();
            var todo = sut.CreateTodo("Det här är min Todo");

            // Action
            sut.AddToList(todo);

            // Assert
            Assert.Equal(todo, sut.Todos.Where(x => x.Id == todo.Id).FirstOrDefault());
        }

        [Fact]
        public void Remove_Todo_From_List()
        {
            // Arrange
            TodoService sut = new TodoService();
            var todo = sut.CreateTodo("Det här är min Todo");
            sut.AddToList(todo);

            // Action
            sut.RemoveFromList(todo);

            // Assert
            Assert.NotEqual(todo, sut.Todos.Where(x => x.Id == todo.Id).FirstOrDefault());
        }
    }
}
