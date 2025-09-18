using System.ComponentModel.DataAnnotations;
namespace MVCMovie.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}