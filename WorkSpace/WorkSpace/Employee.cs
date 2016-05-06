using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    class Employee
    {
        protected String name;
        protected double salary;
        virtual public String GetDescription()
        {
            String empAsString = String.Format("Employee: {0} with salary: {1:C}",name,salary);
            return empAsString;
        }
        public void SetName(String _name)
        {
            name = _name;
        }
        public void SetSalary(double _salary)
        {
            salary = _salary;
        }
        public String GetName()
        {
            return name;
        }
        public double GetSalary()
        {
            return salary;
        }
    }
}
