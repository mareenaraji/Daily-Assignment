using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQSortEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(new Employee("christy", "kottayam"));
            EmpList.Add(new Employee("rose", "idukki"));
            EmpList.Add(new Employee("jasmine", "palakkad"));
            EmpList.Add(new Employee("lilly", "trivandram"));
            EmpList.Add(new Employee("sarath", "alappuzha"));

            var lquery = from Employee employee in EmpList
                         orderby employee.City
                         group employee by employee.City;
            foreach(var f in lquery)
            {
                Console.WriteLine("Employees with " +  f.Key  + " city");
                foreach(var nm in f) 
                {
                    Console.WriteLine(""+nm.Name);
                }
            }





        }
    }
}
