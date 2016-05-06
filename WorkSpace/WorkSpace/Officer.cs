using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    class Officer:Employee
    {
        private double bonus;
        override public String GetDescription()
        {
            String empAsString = String.Format("Officer: {0}, with salary {1:C}, and bonus {2:C}.",name,salary,bonus);
            return empAsString;
        }
        public void SetBonus(double _bonus)
        {
            bonus = _bonus;
        }
        public double GetBonus()
        {
            return bonus;
        }
    }
}
