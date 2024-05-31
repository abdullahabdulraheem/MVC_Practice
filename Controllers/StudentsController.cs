using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVC_Practice.Context;
using MVC_Practice.Models;

namespace MVC_Practice.Controllers
{
    // [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly ToDoDbContext dbContext;
        public StudentsController(ToDoDbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentsView viewModel)
        {
            var student = new Student
            {
                StudentName = viewModel.StudentName,
                Email = viewModel.Email,
                Age = viewModel.Age,
                State = viewModel.State,
                Present = viewModel.Present
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.StudentId);

            if(student is not null)
            {
                student.StudentName = viewModel.StudentName;
                student.Email = viewModel.Email;
                student.Age = viewModel.Age;
                student.State = viewModel.State;
                student.Present = viewModel.Present;
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }

        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.StudentId == viewModel.StudentId);
            if(student is not null)
            {
                dbContext.Students.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}