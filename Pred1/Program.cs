using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pred1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestType testvar = new TestType(10);

            for (int i = 1; i <= 10; i++)
            {
                testvar[i-1] = (int)Math.Pow(2,i);
            }

            foreach (int elem in testvar)
            {
                Console.WriteLine(elem);
            }
            Console.ReadLine();
        }
    }
}
