using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practice.Models
{
    public class AddStudentsView
    {
            public string? StudentName { get; set; }
            public string? Email { get; set; }
            public int Age { get; set; }
            public string? State { get; set; }
            public bool Present { get; set; }
    }
}