using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newProjectTp1.Models
{
    public class Employee
    {
        public Employee(int v1, string v2, string v3, int v4)
        {
            id = v1;
            Name = v2;
            Department = v3;
            Salary = v4;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
