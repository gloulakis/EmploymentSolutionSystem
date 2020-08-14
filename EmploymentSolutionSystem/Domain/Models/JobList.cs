using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

    }
}
