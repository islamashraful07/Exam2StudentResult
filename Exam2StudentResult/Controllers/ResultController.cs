using AutoMapper;
using Exam2StudentResult.Models.Entities;
using Exam2StudentResult.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam2StudentResult.Controllers
{

    public class ResultController : Controller
    {
        private readonly Data.DataContext _context;
        private readonly IMapper _mapper;
        public ResultController(Data.DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            var studentModels = _mapper.Map<List<StudentModel>>(students);
            return View(studentModels);
        }


        public ActionResult SearchedResult(StatusFilter statusFilter)
        {
            var students = _context.Students.ToList();

            var studentModels = new List<StudentModel>();
            studentModels = _mapper.Map<List<StudentModel>>(students);
            if (statusFilter.resultStatus != ResultStatus.All)
            {
                
                studentModels = studentModels.Where(x=>x.ResultStatus == statusFilter.resultStatus).ToList();
            }
           

            
            return View("Index",studentModels);
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
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
