using EmploymentSolutionSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Services
{
    public interface IJobListService
    {
        public void Add(JobList jobList);
       
        public IEnumerable<JobList> GetAll();
    }

}
