using System.ComponentModel.DataAnnotations;

public class Todo
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}";
    }
}