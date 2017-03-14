using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EOH.DataContracts
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
    }
}
