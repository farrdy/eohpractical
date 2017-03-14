using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOH.Model;
using EOH.Data.Repositories;
using EOH.Data.Infrastructure;

namespace EOH.BusinessService
{
    public class EmployeeBusiness : IEmployeeBusiness
    {

        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;
        public EmployeeBusiness(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }
        public Employee CreateEmployee(Employee employee)
        {
           return employeeRepository.Add(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            employeeRepository.Delete(employee);
        }
        public Employee FindEmployee(int id)
        {
            return employeeRepository.GetById(id);
        }
        
        public Employee UpdateEmployee(Employee employee)
        {
            return employeeRepository.Update(employee);
        }
        public void SaveEmployee()
        {
            unitOfWork.Commit();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
