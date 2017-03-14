using EOH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Data
{
    public class EOHEntities : DbContext
    {
        public EOHEntities() : base("EOHEntities") { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public virtual void  Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
        }

    }
}
