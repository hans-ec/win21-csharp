using _02_UWP_TodoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace _02_UWP_TodoApp.Services
{
    internal class TodoService
    {
        private static HttpClient _http = new HttpClient();

        public static async Task<State> CreateTodoAsync(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var item = new TodoItem { Id = Guid.NewGuid(), Title = title };
                var response = await _http.PostAsJsonAsync("https://win21-demo.azurewebsites.net/api/SaveTodo", item);

                if (response.IsSuccessStatusCode)
                    return State.Saved;

                return State.SavedFailed;
            }

            return State.Idle;

        }

        public static async Task<State> RemoveTodoAsync(TodoItem item)
        {
            var response = await _http.PostAsJsonAsync($"https://win21-demo.azurewebsites.net/api/DeleteTodo?id={item.Id}", item);

            if (response.IsSuccessStatusCode)
                return State.Removed;

            return State.RemovedFailed;
        }

        public static async Task<IEnumerable<TodoItem>> GetTodosAsync()
        {
            return await _http.GetFromJsonAsync<IEnumerable<TodoItem>>("https://win21-demo.azurewebsites.net/api/GetTodos");
        }
    }
}
