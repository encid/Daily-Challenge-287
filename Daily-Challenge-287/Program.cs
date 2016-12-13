using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("9184 -> " + LargestDigit(9184));
            Console.ReadLine();
        }

        static string LargestDigit(int input)
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

        static int DescendingDigits(int input)
        {
            return 1;
        }
    }
}
