using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Doctor:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }

        public DateTime Birthday { get; set; }

        public Doctor()
        {
            Employee employee = new Employee();
            employee.Salary=5;
        }
    }
}
