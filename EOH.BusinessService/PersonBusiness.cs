using EOH.Data.Infrastructure;
using EOH.Data.Repositories;
using EOH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.BusinessService
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository personRepository;
        private readonly IUnitOfWork unitOfWork;
        public PersonBusiness(IPersonRepository personRepository, IUnitOfWork unitOfWork)
        {
            this.personRepository = personRepository;
            this.unitOfWork = unitOfWork;
        }

        public Person CreatePerson(Person person)
        {
            return personRepository.Add(person);
        }

        public void Delete(Person  person)
        {
            personRepository.Delete(person);
        }

        public Person FindPerson(int id)
        {
            return personRepository.GetById(id);
        }

       

        public Person UpdatePerson(Person person)
        {
            return personRepository.Update(person);
        }

        public void SavePerson()
        {
            unitOfWork.Commit();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(Person person)
        {
            personRepository.Delete(person);
        }
    }
}
