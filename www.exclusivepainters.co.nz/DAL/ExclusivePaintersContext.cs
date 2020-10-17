using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using www.exclusivepainters.co.nz.Models;

namespace www.exclusivepainters.co.nz.DAL
{
    public class ExclusivePaintersContext:DbContext
    {
        public ExclusivePaintersContext ():base("name =ExclusivePaintersContext")
        {}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<EmployeeForm> EmployeeForms { get; set; }
        public DbSet<Job> Jobs { get; set; }
        /* public DbSet<Vaccancy> Vaccancies { get; set; }

         public DbSet<Login> Logins { get; set; }
         */
        public DbSet<Status> Statuses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}