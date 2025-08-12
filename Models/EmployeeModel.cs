using System;
using System.ComponentModel.DataAnnotations;

namespace Employee_CRUD.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Hire date is required")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Job title is required")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a valid number")]
        public decimal? Salary { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }

        public string Image {  get; set; }
    }
}
