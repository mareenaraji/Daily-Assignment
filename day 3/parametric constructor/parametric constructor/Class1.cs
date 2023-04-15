using System;

namespace parametric_constructor
{
    public class Emp
    {
        public int Empid;
        public string Name;
        public decimal Salary;
        public Emp(int empId, string name, decimal salary)
        {
            Empid = empId;
            Name = name;
            Salary = salary;
        }

    }
}
