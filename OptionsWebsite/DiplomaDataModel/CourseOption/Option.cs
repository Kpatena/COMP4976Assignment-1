using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomaDataModel.CourseOption
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }

        [MaxLength(50, ErrorMessage = "Max Length 50 Characters")]
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
