using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    class EmployeeEqualityCompareTo : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            throw new NotImplementedException();
        }
    }


    class EmployeyComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            x.Salary.CompareTo(y.Salary); 
        }


    }

    internal class Employee: IComparable <Employee> , IEquatable<Employee>
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other is not null) return 1;
            return Age.CompareTo(other.Age); 
        }

        public override bool Equals(object? obj)
        {
            Employee E = (Employee)obj;
            return this == E;
        }

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this== other;
        }

        public override string ToString()
        {
            return ($"Id : {Id} , Age : {Age} , Name {Name} , Salary {Salary}");
        }
    }
}
