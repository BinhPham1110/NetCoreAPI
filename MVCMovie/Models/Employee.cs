using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Position { get; set; }

        [Range(0, 1000000)]
        public decimal Salary { get; set; }
    }
}
