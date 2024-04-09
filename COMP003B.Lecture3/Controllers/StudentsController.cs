using Microsoft.AspNetCore.Mvc;
// TODO: reference Models namespace
using COMP003B.Lecture3.Models;

namespace COMP003B.Lecture3.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> _students = new List<Student>();

        // GET: Students
        public IActionResult Index()
        {
            return View(_students);
        }
    }
}
