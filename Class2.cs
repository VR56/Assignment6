using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class SumTester
    {
        public static void TestReturnsWhenNumbersGreaterThanHundred()
        {
            Random random = new Random();
            try
            {
                SimpleSumClass test = new SimpleSumClass();
                int result = test.Sum(random.Next(100, 200), random.Next(100, 200));
                if (result > 100 && result < 100)
                    Console.WriteLine("The Numbers Entered are More than 100");
                

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }

        }
    }
}
