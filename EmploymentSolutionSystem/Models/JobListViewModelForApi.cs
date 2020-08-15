using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Models
{
    public class JobListViewModelForApi
    {
        public int Order { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public string JobPosition { get; set; }

        public string JobSalary { get; set; }
    }
}
