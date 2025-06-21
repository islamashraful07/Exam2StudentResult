using Exam2StudentResult.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam2StudentResult.Controllers
{

    public class ResultController : Controller
    {
        private readonly Data.DataContext _context;
        public ResultController(Data.DataContext context)
        {
            _context = context;
        }
        
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }


        
        public ActionResult Create()
        {
           
            return View();
        }

        
        [HttpPost]
        
        public ActionResult Create(StudentModel studentModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(studentModel);
                }
                var student = new Models.Entities.Student
                {
                    Name = studentModel.Name,
                    CourseTitle = studentModel.CourseTitle,
                    Marks = studentModel.Marks
                };
                
                _context.Students.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
