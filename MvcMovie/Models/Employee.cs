using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}