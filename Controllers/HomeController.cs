using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Practice.Models;

namespace MVC_Practice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // public IActionResult Index()
    // {
    //          List<Student> studentList = new List<Student>(){ 
    //             new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
    //             new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
    //             new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
    //             new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
    //             new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
    //             new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
    //             new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 } 
    //         };
    //     //fetch students from the DB using Entity Framework here

    //     return View(studentList);
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
