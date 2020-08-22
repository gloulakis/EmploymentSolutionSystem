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

        public JobList CompanyJobList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IEnumerable<Company> company { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Add(Company company)
        {
            db.company.Add(company);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Company com = this.GetById(id);
            db.company.Remove(com);
            db.SaveChanges();
        }

        public void Edit(Company company)
        {
            var CompanyEdit = db.company.FirstOrDefault(J => J.Id == company.Id);
            if (company != null)
            {
                CompanyEdit.CompanyName = company.CompanyName;
                CompanyEdit.CompanyEmail = company.CompanyEmail;
                CompanyEdit.CompanyTelephoneNumber = company.CompanyTelephoneNumber;
                CompanyEdit.CompanyCity = company.CompanyCity;
                CompanyEdit.CompanyAddress = company.CompanyAddress;
                CompanyEdit.CompanyLogo = company.CompanyLogo;
                CompanyEdit.CompanyZIPCode = company.CompanyZIPCode;
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
