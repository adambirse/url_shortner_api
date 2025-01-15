using System.ComponentModel.DataAnnotations;

public class ExampleModel
{
    [Required]
    public string Name { get; set; }
    [Range(0, 100)]
    public int Age { get; set; }
}