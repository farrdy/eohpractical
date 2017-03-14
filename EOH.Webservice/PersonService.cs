using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EOH.DataContracts;
using EOH.BusinessService;
using AutoMapper;

namespace EOH.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Person" in both code and config file together.
    public class PersonService : IPersonService
    {


        private readonly IPersonBusiness employeeBusiness;
        public PersonService() { }
        public PersonService(IPersonBusiness repo)
        {
            employeeBusiness = repo;
        }
        public Person CreatePerson(Person person)
        {
            var response = employeeBusiness.CreatePerson(Mapper.Map<Person, Model.Person>(person));
            return Mapper.Map<Model.Person, DataContracts.Person>(response);
        }

        public void DeletePerson(Person person)
        {
            employeeBusiness.DeletePerson(Mapper.Map<Person, Model.Person>(person));
        }

        public Person FindPersonById(int id)
        {
            var response = employeeBusiness.FindPerson(id);
            return Mapper.Map<Model.Person, DataContracts.Person>(response);
        }

        public Person UpdatePerson(Person person)
        {
            var response = employeeBusiness.UpdatePerson(Mapper.Map<Person, Model.Person>(person));
            return Mapper.Map<Model.Person, DataContracts.Person>(response);
        }
    }
}
