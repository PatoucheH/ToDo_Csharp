using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorToDoApp.Models
{
    public class TodoService
    {
        private const string StorageKey = "todos";
        private readonly ILocalStorageService _localStorage;

        public TodoService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<List<ToDo>> GetTodosAsync()
        {
            return await _localStorage.GetItemAsync<List<ToDo>>(StorageKey) ?? new List<ToDo>();
        }

        public async Task SaveTodosAsync(List<ToDo> todos)
        {
            await _localStorage.SetItemAsync(StorageKey, todos);
        }
    }
}