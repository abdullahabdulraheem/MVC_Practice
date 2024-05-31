namespace MVC_Practice.Models;

public class Student
{
    public Guid StudentId { get; set; }

    public string? StudentName { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
    public string? State { get; set; }
    public bool Present { get; set; }
}