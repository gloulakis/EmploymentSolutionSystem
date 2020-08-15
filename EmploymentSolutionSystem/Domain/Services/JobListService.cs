using EmploymentSolutionSystem.Data;
using EmploymentSolutionSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Services
{
    public class JobListService : IJobListService
    {
        private readonly ApplicationDbContext db;

        public JobListService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(JobList jobList)
        {
            db.Joblist.Add(jobList);
            db.SaveChanges();
        }

        public IEnumerable<JobList> GetAll()
        {
            return db.Joblist.ToList();
        }
    }
}
