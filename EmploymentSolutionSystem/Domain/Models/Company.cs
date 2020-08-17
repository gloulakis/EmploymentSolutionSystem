using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Domain.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyEmail { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public string CompanyTelephoneNumber { get; set; }

        [Required]
        public string CompanyCity { get; set; }

        [Required]
        public string CompanyAddress { get; set; }

        [Required]
        public string CompanyZIPCode { get; set; }

        [Required]
        public string CompanyLogo { get; set; }
    }
}
