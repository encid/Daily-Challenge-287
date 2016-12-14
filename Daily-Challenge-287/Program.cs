using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Output number ordered from largest to smallest digit:");
            Console.WriteLine("9184 -> " + DescendingDigits(9184));
            Console.WriteLine("417 -> " + DescendingDigits(417));
            Console.WriteLine("45 -> " + DescendingDigits(45));
            Console.WriteLine("2850 -> " + DescendingDigits(2850));
            Console.WriteLine("-----------------");
            Console.WriteLine("Output the largest digit:");
            Console.WriteLine("9184 -> " + LargestDigit(9184));
            Console.WriteLine("417 -> " + LargestDigit(417));
            Console.WriteLine("45 -> " + LargestDigit(45));
            Console.WriteLine("2850 -> " + LargestDigit(2850));


            Console.ReadLine();
        }

        static string DescendingDigits(int input)
        {
            List<char> numList = ConvertNumberToDescendingList(input);

            string s = "";
            foreach (var item in numList) {
                s += item;
            }

            return s;
        }

        static string LargestDigit(int input)
        {
            List<char> numList = ConvertNumberToDescendingList(input);

            return numList[0].ToString();

        }

        static List<char> ConvertNumberToDescendingList(int input)
        {
            string number = input.ToString("0000");
            List<char> numList = number.OrderByDescending(x => x).ToList();

            return numList;
        }
    }
}
