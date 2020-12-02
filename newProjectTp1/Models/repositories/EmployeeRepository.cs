using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newProjectTp1.Models.repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        List<Employee> lemployees;
        public EmployeeRepository()
        {
            lemployees = new List<Employee>
                {
                    new Employee(1,"Farouk","info",1500000),
                     new Employee(2,"Farouk","info",1500000),
                      new Employee(3,"Farouk","info",1500000),
                       new Employee(4,"Farouk","info",1500000)
                };
        }



        public void Add(Employee entity)
        {
            lemployees.Add(entity);
        }

        public void Delete(int id)
        {
            var emp = FindByID(id);
            lemployees.Remove(emp);

        }

        public Employee FindByID(int id)
        {
            var emp = lemployees.FirstOrDefault(a => a.id == id);
            return emp;
        }

        public IList<Employee> GetAll()
        {
            return lemployees;
        }

        public int HrEmployeeCOunt()
        {
            return lemployees.Where(x => x.Department == "HR").Count();

        }

        public double MaxSalary()
        {
            return lemployees.Max(x => x.Salary);
        }

        public double SalaryAverage()
        {
            return lemployees.Average(x => x.Salary);
        }

        public List<Employee> Search(string term)
        {
            if (!string.IsNullOrEmpty(term))
                return lemployees.Where(a => a.Name.Contains(term)).ToList();
            else
                return lemployees;
        }

        public void Update(int id, Employee entity)
        {
            var emp = FindByID(id);
            emp.Name = entity.Name;
            emp.Department = entity.Department;
            emp.Salary = entity.Salary;
           


        }
    }
}
