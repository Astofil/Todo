using Dapper;
using Domain.Dtos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TodoService
    {
        private string _connectionString = "Server=127.0.0.1;Port=5432;Database=TodoListdemoApp;User Id=postgres;Password=151204;";
        public List<Todo> GetTodos()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"select * from todos";
                var result = conn.Query<Todo>(sql).ToList();
                return result;
            }
        }
        public int AddTodo(Todo todo)
        {
            using ( var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"insert into todos (TaskName,Status) Values('{todo.TaskName}', {(int)todo.Status})";
                var result = conn.Execute(sql);
                return result;
            }
        }
        public int UpdateTodo(Todo todo)   //edit-todo
        {
            using ( var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Update todos set TaskName = '{todo.TaskName}', Status = {todo.Status}";
                var result = conn.Execute(sql);
                return result;
            }
        }
        public int DeleteTodo(int id)
        {
            using ( var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"delete from todos where id = {id}";
                var result = conn.Execute(sql);
                return result;
            }
        }
    }
}
