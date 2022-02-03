using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baratheon_Trippin.Models
{
    internal class DataStore
    {
        public List<Employee> Employees { get; } = new List<Employee>();
        public void GenEmployeeReport()
        {
            Console.WriteLine("Employee Report");
            Console.WriteLine("-----------------");
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
