using AutoMapper;

namespace Exam2StudentResult.Data
{
    public class CustomMapper:Profile
    {
        public CustomMapper() 
        { 
            CreateMap<Models.Entities.Student, Models.ViewModels.StudentModel>()
                .ForMember(dest => dest.ResultStatus, opt => opt.Ignore())
                .ReverseMap();

        }
    }
}
