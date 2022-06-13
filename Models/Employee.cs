using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? Languages { get; set; }
        public int? Proficiency { get; set; }
    }
}
