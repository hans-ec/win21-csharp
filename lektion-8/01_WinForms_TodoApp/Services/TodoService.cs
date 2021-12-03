using _01_WinForms_TodoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace _01_WinForms_TodoApp.Services
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

        public static async Task<State> RemoveTodoAsync(string title)
        {
            var items = await GetTodosAsync();
            var item = items.FirstOrDefault(x => x.Title == title);

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
