using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Practice.Models;

public class ToDo
{
    public Guid ID { get; set; }
    
    [StringLength(100)]
    [DisplayName ("Task Name")]
    public required string TaskName { get; set; }
    public DateTime CreatedAt { get; set; }
    [DisplayName ("Due Date")]
    public DateTime DueDate { get; set; }
    public required string Description { get; set; }
}