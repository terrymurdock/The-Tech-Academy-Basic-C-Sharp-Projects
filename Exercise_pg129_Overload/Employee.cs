using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg129_Overload
{
    class Employee : IComparable<Employee>
    {
        public int id { get; set; }
        public Employee(int n)
        {
            id = n;
        }
        public int CompareTo(Employee other)
        {
            if (id == other.id)
                return 1;
            else if (id == other.id)
                return -1;
            else
                return 0;
        }

        public static bool operator ==(Employee id1, Employee id2)
        {
            return id1.Equals(id2);
        }

        public static bool operator !=(Employee id1, Employee id2)
        {
            return !(id1.Equals(id2));
        }

    }
}
