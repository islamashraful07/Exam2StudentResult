using Exam2StudentResult.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Exam2StudentResult.Models.ViewModels
{
    public class StudentModel
    {
       
            [Key]
            public int Id { get; set; }
            [Required]
            public required string Name { get; set; }
            [Required]
            public coursetitle CourseTitle { get; set; }
            [Required]
            [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100.")]
            public int Marks { get; set; }
            public ResultStatus ResultStatus
            {
                get
                {
                    if (Marks >= 80)
                        return ResultStatus.Excellent;
                    else if (Marks >= 50 && Marks < 80 )
                        return ResultStatus.Good;
                    else
                        return ResultStatus.NeedsImprovement;
                    
                }
            }

    }
}
