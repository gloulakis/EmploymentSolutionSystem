using EmploymentSolutionSystem.Domain.Models;
using System.Collections.Generic;

namespace EmploymentSolutionSystem.Domain.Services
{
    public interface ICompanyService
    {
        public void Add(Company company);

        public JobList CompanyJobList { get; set; }

        public IEnumerable<Company> company { get; set; }

        Company GetById(int id);

        void Edit(Company company);

        public IEnumerable<Company> GetAll();

        public void Delete(int id);
    }
}
