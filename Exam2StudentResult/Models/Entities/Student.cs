using System.ComponentModel.DataAnnotations;

namespace Exam2StudentResult.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public coursetitle CourseTitle { get; set; }
        [Required]
        public int Marks { get; set; }
       
    }

}
