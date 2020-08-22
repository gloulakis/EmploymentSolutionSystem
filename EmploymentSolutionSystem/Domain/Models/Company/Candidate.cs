using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmploymentSolutionSystem.Domain.Models
{
    public class Candidate
    {
        [Key]
        public int Can_Id { get; set; }

        public string Can_Name { get; set; }

        public string Can_LastName { get; set; }

        public string Email { get; set; }

        public string Can_CV { get; set; }

        [ForeignKey("JobList")]
        public int Job_Id { get; set; }
    }
}
