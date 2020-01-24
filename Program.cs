using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class SimpleSumClass
    {
        public int Sum(int Number1,int Number2)
        {
            
            if (Number1 > 100 && Number2 > 100)
                throw new NumberGreaterThanHundred("The Numbers are greater than 100");
            else {
                return Number1 + Number2;
            }
                

            
        }
    }
}
