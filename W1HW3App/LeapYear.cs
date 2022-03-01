using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Year ：");
            long Y = Convert.ToInt64(Console.ReadLine());
            
            if (Y % 4 == 0)//当Y可以被4整除时
            {   
                if (Y % 100 != 0)//当Y不能被100整除时
                {
                    Console.WriteLine("Year is a Leap ");
                }
                else if (Y % 400 == 0)//当Y可以被400整除时
                {
                    Console.WriteLine("Year is a Leap ");
                }
                else//当Y可以被100整除时
                {
                    Console.WriteLine("Year is not a Leap");
                }
            }
            else//当Y不能被4整除时
            {
                Console.WriteLine("Year is not a Leap");
            }
            Console.ReadLine();
        }
    }
}
