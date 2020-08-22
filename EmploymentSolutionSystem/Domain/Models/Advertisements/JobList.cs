using System;
using System.ComponentModel.DataAnnotations;

namespace EmploymentSolutionSystem.Domain.Models
{
    public class JobList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string JobDescription { get; set; }

        [Required]
        public string JobPosition { get; set; }

        public string JobSalary { get; set; }


        public string JobImage { get; set; }

    }
}
