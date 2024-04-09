// TODO: add data annotations library
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Lecture3.Models
{
    public class Student
    {
        // TODO: data in square brackets are data notations
        [Required]
        // TODO: below is an example of a property
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Required]
        [Range(0, 120)]
        public int Age { get; set; }

    }
}
