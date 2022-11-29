using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController
    {
        private TodoService _todoService;
        public TodoController()
        {
            _todoService = new TodoService();
        }
        
        [HttpGet("Get Todo")]
        public List<Todo> GetTodos()
        {
            return _todoService.GetTodos();
        }

        [HttpPost("Add todoes")]
        public int AddTodo(Todo todo)
        {
            return _todoService.AddTodo(todo);
        }

        [HttpPut("update ")]
        public int UpdateTodo(Todo todo)
        {
            return _todoService.UpdateTodo(todo);
        }

        [HttpDelete("delete todo")]
        public int DeleteTodo(int id)
        {
            return _todoService.DeleteTodo(id);
        }
    }
}


