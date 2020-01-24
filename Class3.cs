using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Class3
    {
        public static void Main(String[] args)
        {
            try
            {
                SumTester.TestReturnsWhenNumbersGreaterThanHundred();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
