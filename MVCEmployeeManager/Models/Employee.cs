using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEmployeeManager.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Employee First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Employee Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Employee Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Employee BirthDate is required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Employee HireDate is required")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "Employee Country is required")]
        public String Country { get; set; }
        public string Notes { get; set; }
    }
}
