using EOH.Data.Infrastructure;
using EOH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EOH.Data.Repositories
{
  public   class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbFactory dbFactory): base(dbFactory) { }

    

       
    }
}
