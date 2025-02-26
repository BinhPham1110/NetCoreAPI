using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Person 
    {
        [Key]
        public String PersonID { get; set;}
        public String FullName { get;set;}
        public String Address { get; set;}
    }
}