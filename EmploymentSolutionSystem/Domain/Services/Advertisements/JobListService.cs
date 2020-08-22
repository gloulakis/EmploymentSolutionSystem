using EmploymentSolutionSystem.Data;
using EmploymentSolutionSystem.Domain.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Delete(int id)
        {
            JobList job = this.GetById(id);
            db.Joblist.Remove(job);
            db.SaveChanges();
        }

        public void Apply(int id)
        {
            JobList job = this.GetById(id);
        }

        public void Edit(JobList jobList)
        {
            var JobEdit = db.Joblist.FirstOrDefault(J => J.Id == jobList.Id);
            if (JobEdit != null)
            {
                JobEdit.JobTitle = jobList.JobTitle;
                JobEdit.JobPosition = jobList.JobPosition;
                JobEdit.JobDescription = jobList.JobDescription;
                JobEdit.JobSalary = jobList.JobSalary;
                JobEdit.JobImage = jobList.JobImage;
                db.SaveChanges();
            }
        }


        public IEnumerable<JobList> GetAll()
        {
            return db.Joblist.ToList();
        }

        public JobList GetById(int id)
        {
            return db.Joblist.FirstOrDefault(J => J.Id == id);
        }



    }
}
