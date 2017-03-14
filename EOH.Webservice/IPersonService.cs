using EOH.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EOH.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerson" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        Person CreatePerson(Person person);

        [OperationContract]
        Person UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(Person person);

        [OperationContract]
        Person FindPersonById(int id);
    }
}
