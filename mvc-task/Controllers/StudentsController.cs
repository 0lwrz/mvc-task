using Microsoft.AspNetCore.Mvc;

namespace mvc_task.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult getAll()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
