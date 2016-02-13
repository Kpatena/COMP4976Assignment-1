using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DiplomaDataModel.CourseOption.CustomValidation;

namespace DiplomaDataModel.CourseOption
{
    public class Choice
    {

        public int ChoiceId { get; set; }

        [ForeignKey("YearTerm")]
        public int YearTermId { get; set; }

        [StartWith("A00", ErrorMessage = "Student ID needs to start with A00")]
        [MaxLength(9, ErrorMessage = "Max Legnth 9 Characters")]
        public string StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name Required")]
        public string StudentFirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name Required")]
        public string StudentLastName { get; set; }

        [Required(ErrorMessage = "First Option Required")]
        [Display(Name = "First Choice: ")]
        [ForeignKey("FirstOption")]
        public int? FirstChoiceOptionId { get; set; }
        [ForeignKey("FirstChoiceOptionId")]
        public Option FirstOption { get; set; }

        [Required(ErrorMessage = "Second Option Required")]
        [Display(Name = "Second Choice: ")]
        [ForeignKey("SecondOption")]
        public int? SecondChoiceOptionId { get; set; }
        [ForeignKey("SecondChoiceOptionId")]
        public Option SecondOption { get; set; }

        [Required(ErrorMessage = "Third Option Required")]
        [Display(Name = "Third Choice: ")]
        [ForeignKey("ThirdOption")]
        public int? ThirdChoiceOptionId { get; set; }
        [ForeignKey("ThirdChoiceOptionId")]
        public Option ThirdOption { get; set; }

        [Required(ErrorMessage = "Fourth Option Required")]
        [Display(Name = "Fourth Choice: ")]
        [ForeignKey("FourthOption")]
        public int? FourthChoiceOptionId { get; set; }
        [ForeignKey("FourthChoiceOptionId")]
        public Option FourthOption { get; set; }

        [Display(AutoGenerateField= false)]
        public DateTime SelectionDate { get; set; }

        public ICollection<Option> Options { get; set; }
        public ICollection<YearTerm> YearTerms { get; set; }
    }
}
