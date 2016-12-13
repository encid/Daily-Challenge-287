using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("9184 -> " + DescendingDigits(9184));
            Console.WriteLine("417 -> " + DescendingDigits(417));
            Console.WriteLine("45 -> " + DescendingDigits(45));
            Console.WriteLine("2850 -> " + DescendingDigits(2850));
            Console.ReadLine();
        }

        static string DescendingDigits(int input)
        {
            string number = input.ToString();
            switch (number.Length) {
                case 1:
                number = "000" + number;
                break;
                case 2:
                number = "00" + number;
                break;
                case 3:
                number = "0" + number;
                break;
                case 4:
                break;
                //default:
                //return -1;
            }

            List<char> nums = number.OrderByDescending(x => x).ToList();

            string s = "";
            foreach (var item in nums) {
                s += item;
            }

            return s;
        }

        static int LargestDigit(int input)
        {
            return 1;
        }
    }
}
