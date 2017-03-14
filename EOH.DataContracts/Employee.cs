using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EOH.DataContracts
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeID { get; set; }       
        public int PersonID { get; set; }
        [DataMember]
        public string EmployeeNum { get; set; }
        [DataMember]
        public DateTime EmployeedDate { get; set; }
        [DataMember]
        public DateTime TerminatedDate { get; set; }
    }
}
