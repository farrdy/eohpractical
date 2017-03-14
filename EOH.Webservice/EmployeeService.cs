
using EOH.BusinessService;
using EOH.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;

namespace EOH.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeBusiness employeeRepository;

        public EmployeeService() { }
        public EmployeeService(IEmployeeBusiness repo) {
            employeeRepository = repo;
        }
        public Employee CreateEmployee(Employee employee)
        {
          var response= employeeRepository.CreateEmployee(Mapper.Map<Employee, Model.Employee>(employee));
            return Mapper.Map<Model.Employee, DataContracts.Employee>(response);
        }
        
        public void DeleteEmployee(Employee employee)
        {
            employeeRepository.DeleteEmployee(Mapper.Map<Employee, Model.Employee>(employee));
        }

        public Employee FindEmployeeById(int id)
        {
            var response= employeeRepository.FindEmployee(id);
            return Mapper.Map<Model.Employee, DataContracts.Employee>(response);
        }
        
       
        public Employee UpdateEmployee(Employee employee)
        {
           var response= employeeRepository.UpdateEmployee(Mapper.Map<Employee, Model.Employee>(employee));
            return Mapper.Map<Model.Employee, DataContracts.Employee>(response);
        }
    }
}
