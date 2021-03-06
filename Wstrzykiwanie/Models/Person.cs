using System.ComponentModel.DataAnnotations;
namespace Wstrzykiwanie.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [Display(Name = "Rok")]
        [Required(ErrorMessage = "Pole rok jest wymagane")]
        [Range(1899, 2022, ErrorMessage = "Rok musi mieścić się w zakresie od 1899 do 2022")]
        public int? Year { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole imię jest wymagane")]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Display(Name = "Nazwisko")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Display(Name = "DataRetrievedTime")]
        public DateTime DataRetrievedTime { get; set; }

        public bool IsLeapYear => (this.Year % 4 == 0) && (this.Year % 100 != 0) || (this.Year % 400 == 0);
    }
}
