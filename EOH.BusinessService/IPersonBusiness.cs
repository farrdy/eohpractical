using EOH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.BusinessService
{
  public  interface IPersonBusiness
    {
        Person CreatePerson(Person person);
      
        Person FindPerson(int id);
        Person UpdatePerson(Person employee);

        void DeletePerson(Person person);

        void SavePerson();
    }
}
