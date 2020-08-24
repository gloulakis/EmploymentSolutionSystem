using EmploymentSolutionSystem.Data;
using EmploymentSolutionSystem.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmploymentSolutionSystem.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext db;

        public CompanyService(ApplicationDbContext db)
        {
            this.db = db;
        }

      

        public void Add(Company company)
        {
            db.company.Add(company);
            db.SaveChanges();
        }

        public IEnumerable<Company> GetAll()
        {
            return db.company.ToList();
        }


    }
}
