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

        public void Edit(Company company)
        {
            var ComEdit = db.company.FirstOrDefault(J => J.Id == company.Id);
            if (ComEdit != null)
            {
                ComEdit.BULSTAT = company.BULSTAT;
                ComEdit.CompanyAddress = company.CompanyAddress;
                ComEdit.CompanyCity = company.CompanyCity;
                ComEdit.CompanyEmail = company.CompanyEmail;
                ComEdit.CompanyLogo = company.CompanyLogo;
                ComEdit.CompanyName = company.CompanyName;
                ComEdit.CompanyTelephoneNumber = company.CompanyTelephoneNumber;
                ComEdit.CompanyZIPCode = company.CompanyZIPCode;
                db.SaveChanges();
            }
        }

        public IEnumerable<Company> GetAll()
        {
            return db.company.ToList();
        }

        public Company GetById(int id)
        {
            return db.company.FirstOrDefault(J => J.Id == id);
        }
    }
}
