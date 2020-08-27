using EmploymentSolutionSystem.Domain.Models;
using System.Collections.Generic;

namespace EmploymentSolutionSystem.Domain.Services
{
    public interface ICompanyService
    {
        public void Add(Company company);

        void Edit(Company company);

        public IEnumerable<Company> GetAll();

        Company GetById(int id);

    }
}
