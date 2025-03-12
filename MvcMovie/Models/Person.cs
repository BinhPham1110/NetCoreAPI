using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Personss")]
    public class Person 
    {
        [Key]
        public String PersonID { get; set;}
        public String FullName { get;set;}
        public String Address { get; set;}
    }
}