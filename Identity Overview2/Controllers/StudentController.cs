using Identity_Overview2.Data; // Ensure this points to your Data folder
using Identity_Overview2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Overview2.Controllers
{
    public class StudentController : Controller
    {
        // 1. Create a private field to hold the database context
        private readonly ApplicationDbContext _context;

        // 2. Use the Constructor to "Inject" the context
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Optional: Retrieve the list of students to show on the page
            var students = _context.Student.ToList();
            return View(students);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Security best practice for forms
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Student.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // If we got this far, something failed; redisplay the form
            return View(student);
        }
    }
}