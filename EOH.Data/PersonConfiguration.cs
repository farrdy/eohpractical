using EOH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Data
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration() {
            ToTable("Person");            
            Property(i => i.FirstName).HasMaxLength(128);
            Property(i => i.LastName).HasMaxLength(128);
            

        }
    }
}
