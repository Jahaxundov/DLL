using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Contorellers
{
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;
        public readonly int age;
        public const int Number=55;

        public EmployeeController()
        {
            _employeeService =new EmployeeService();

            age = 33;
        }
        public void GetAllEmployyes()
        {
            var employyes = _employeeService.GetAll();
            foreach ( var employee in employyes)
            {
                string result = $"{employee.Id}, {employee.Name}, {employee.Surname}, {employee.Salary}";
                Console.WriteLine(result);
            }
        }

        public void GetEmployeeById()
        {
            int id = 1;
            var employee=_employeeService.GetById(id);
            Console.WriteLine(employee.Id+ ","+employee.Name);

        }
    }


}
