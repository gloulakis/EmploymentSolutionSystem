using System.ComponentModel.DataAnnotations;

namespace EmploymentSolutionSystem.Domain.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string JobStatus { get; set; }
    }
}
