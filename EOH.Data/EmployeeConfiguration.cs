using EOH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Data
{
   public  class EmployeeConfiguration: EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration() {
            ToTable("Employee");
            Property(e => e.EmployeeNum).HasMaxLength(16);
            Property(e => e.PersonID).IsRequired();
        }
    }
}
