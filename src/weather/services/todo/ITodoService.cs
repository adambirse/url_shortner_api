namespace services.todo;

public interface ITodoService
{
    Task<Todo[]> GetUserTodosAsync();
}