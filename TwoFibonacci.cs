using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = 1,SecondNum = 2,evenSum = 2,sum = 0;
            while(FirstNum + SecondNum < 4000000)
            {
                sum = FirstNum + SecondNum;
                FirstNum = SecondNum;
                SecondNum = sum;
                if(sum % 2 == 0)
                {
                    evenSum += sum;
                }
            }
            Console.WriteLine("The sum of even valued terms in Fibonacci series till 4000000 is " + evenSum);
            Console.ReadLine();
        }
    }
}
