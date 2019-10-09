using System;
using System.Collections.Generic;
using System.Text;
using CM.Core.Entities;
using CM.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CM.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region Private Properties
        private readonly Repository<Customer> customerRepository;

        private readonly Repository<Department> DepartmentRepository;

        #endregion

        #region DbSets
        public DbSet<Customer> Customer { get; set; }
        
        public DbSet<Department> Department { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
