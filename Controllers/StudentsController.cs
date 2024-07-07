using FirstApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly CustomDbContext _context;
        public StudentsController(CustomDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            return View(students);
        }
    }
}
