using CourseManagerApp.Data;
using CourseManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagerApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students/Create
        public IActionResult Create(int courseId)
        {
            if (courseId == 0)
            {
                return NotFound("CourseId is missing.");
            }

            ViewBag.StatusList = Enum.GetValues(typeof(EnrollmentStatus))
                .Cast<EnrollmentStatus>()
                .Select(status => new SelectListItem
                {
                    Value = status.ToString(),
                    Text = status.ToString()
                })
                .ToList();

            ViewBag.CourseId = courseId;

            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,Name,Email,Status,CourseId")] Student student)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("ModelState is valid.");

                _context.Add(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Courses", new { id = student.CourseId });
            }

            Console.WriteLine("ModelState is invalid.");
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Error: {error.ErrorMessage}");
            }

            ViewBag.StatusList = Enum.GetValues(typeof(EnrollmentStatus))
                .Cast<EnrollmentStatus>()
                .Select(status => new SelectListItem
                {
                    Value = status.ToString(),
                    Text = status.ToString()
                })
                .ToList();

            ViewBag.CourseId = student.CourseId;

            return View(student);
        }
    }
}
