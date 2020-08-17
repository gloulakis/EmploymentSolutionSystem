using EmploymentSolutionSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Domain.Services
{
    public interface ICompanyService
    {
        public void Add(Company company);

        Company GetById(int id);

        void Edit(Company company);


        public IEnumerable<Company> GetAll();

        public void Delete(int id);
    }
}
