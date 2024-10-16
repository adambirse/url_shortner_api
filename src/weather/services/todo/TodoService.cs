using System.Text.Json;

namespace services.todo;

public sealed class TodoService(
    IHttpClientFactory httpClientFactory) : ITodoService
{
    public async Task<Todo[]> GetUserTodosAsync()
    {
        // Create the client
        using HttpClient client = httpClientFactory.CreateClient();

        try
        {
            // Make HTTP GET request
            // Parse JSON response deserialize into Todo types
            Todo[]? todos = await client.GetFromJsonAsync<Todo[]>(
                $"https://jsonplaceholder.typicode.com/todos",
                new JsonSerializerOptions(JsonSerializerDefaults.Web));

            return todos ?? [];
        }
        catch (Exception ex)
        {
            //
            throw ex;
        }
    }
}