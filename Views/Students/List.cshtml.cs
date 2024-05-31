using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MVC_Practice.Views.Students
{
    public class List : PageModel
    {
        private readonly ILogger<List> _logger;

        public List(ILogger<List> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}