using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ThreeSumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Pow(2, 1000);
            char[] charNum = number.ToString().ToCharArray();
            int len = charNum.Length;
            double sum = 0;
            for(int i=0; i < len; i++)
            {
                sum += Char.GetNumericValue(charNum[i]);
            }
            Console.WriteLine("The sum of the digits of the number 2^1000 is "+sum);
            Console.ReadLine();
        }
    }
}
