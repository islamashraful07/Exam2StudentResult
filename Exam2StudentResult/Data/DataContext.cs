using Exam2StudentResult.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam2StudentResult.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
    
}
