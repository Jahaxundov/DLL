using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmployeeService
    {
        public Employee GetById(int id)
        {
            var employyes = GetAll();
            foreach (Employee employee in employyes)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public Employee[] GetAll()
        {
            Employee[] employees =
            {
                 
                new Employee
                {   Id=1,
                    Name = "Ismayil",
                    Surname="Afandizade",
                    Age=29,
                    Salary=1200


                },

                new Employee
                {   Id=2,
                    Name = "Xayyam",
                    Surname="Isgenderov",
                    Age=30,
                    Salary=1100

                },
                  
                new Employee
                {   Id=3,
                    Name = "Cahangir",
                    Surname="Axundov",
                    Age=20,
                    Salary=1000

                }
            };
            return employees;
              
        }
    }
}
