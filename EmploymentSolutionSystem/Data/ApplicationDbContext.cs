﻿using System;
using System.Collections.Generic;
using System.Text;
using EmploymentSolutionSystem.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmploymentSolutionSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JobList> Joblist { get; set; }
        public DbSet<Company> company { get; set; }
    }
}
