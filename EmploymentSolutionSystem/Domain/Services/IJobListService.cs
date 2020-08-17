using System.Collections.Generic;
using EmploymentSolutionSystem.Domain.Models;

namespace EmploymentSolutionSystem.Services
{
    public interface IJobListService
    {
        public void Add(JobList jobList);

        JobList GetById(int id);

        void Edit(JobList jobList);

        public IEnumerable<JobList> GetAll();

        public void Delete(int id);
    }

}
