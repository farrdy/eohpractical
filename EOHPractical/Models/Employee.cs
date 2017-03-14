using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Model
{

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public string EmployeeNum { get; set; }
        public DateTime EmployeedDate { get; set; }
        public DateTime TerminatedDate { get; set; }
     




    }
}
