using EmploymentSolutionSystem.Data;
using EmploymentSolutionSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Domain.Services
{
    public class JobListServices : IJobListServices
    {
        private List<JobList> jobLists = new List<JobList>();

        public void Add(JobList jobList)
        {
            jobLists.Add(jobList);
        }
    }
}
