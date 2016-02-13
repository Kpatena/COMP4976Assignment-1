using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DiplomaDataModel.CourseOption
{
    public class CourseOptionContext : DbContext
    {
        public CourseOptionContext() : base("DefaultConnection") { }
        public DbSet<Option> Options { get; set; }
        public DbSet<YearTerm> YearTerms { get; set; }
        public DbSet<Choice> Choices { get; set; }
    }
}
