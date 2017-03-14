using EOH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.BusinessService
{
   public interface IEmployeeBusiness
    {
     
        Employee FindEmployee(int id);
        Employee UpdateEmployee(Employee employee);

        Employee CreateEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        void SaveEmployee();
    }
}
