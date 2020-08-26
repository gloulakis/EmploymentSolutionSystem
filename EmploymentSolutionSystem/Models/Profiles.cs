using AutoMapper;
using EmploymentSolutionSystem.Domain.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Models.ViewModels
{
    public class Profiles:Profile
    {
        public Profiles()
        {
            CreateMap<JobList, JobListViewModel>();
        }
    }
}
