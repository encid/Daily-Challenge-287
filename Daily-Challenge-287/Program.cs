using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Output number ordered from largest to smallest digit:");
            Console.WriteLine("9184 -> " + ConvertToDescending(9184));
            Console.WriteLine("417 -> " + ConvertToDescending(417));
            Console.WriteLine("45 -> " + ConvertToDescending(45));
            Console.WriteLine("2850 -> " + ConvertToDescending(2850));

            Console.WriteLine(" ");
            Console.WriteLine("Output the largest digit:");
            Console.WriteLine("9184 -> " + LargestDigit(9184));
            Console.WriteLine("417 -> " + LargestDigit(417));
            Console.WriteLine("45 -> " + LargestDigit(45));
            Console.WriteLine("2850 -> " + LargestDigit(2850));

            Console.WriteLine(" ");
            Console.WriteLine("Kaprekar routine iterations:");
            Console.WriteLine("Kaprekar(6589) -> " + Kaprekar(6589));
            Console.WriteLine("Kaprekar(5455) -> " + Kaprekar(5455));
            Console.WriteLine("Kaprekar(6174) -> " + Kaprekar(6174));
            Console.WriteLine("Kaprekar(1000) -> " + Kaprekar(1000));

            Console.WriteLine(" ");
            Console.WriteLine("Most Kaprekar iterations: " + LargestKaprekar().ToString());

            Console.ReadLine();
        }

        static string LargestDigit(int input)
        {
            string number = input.ToString("0000");
            List<char> numList = number.OrderByDescending(x => x).ToList();

            return numList[0].ToString();
        }

        static int ConvertToDescending(int input)
        {
            string number = input.ToString("0000");
            List<char> numList = number.OrderByDescending(x => x).ToList();

            string s = "";
            foreach (var item in numList) 
                s += item;            

            return Convert.ToInt32(s);
        }

        static int ConvertToAscending(int input)
        {
            string number = input.ToString("0000");
            List<char> numList = number.OrderBy(x => x).ToList();

            string s = "";
            foreach (var item in numList)
                s += item;            

            return Convert.ToInt32(s);
        }

        static int Kaprekar(int input)
        {
            // Check if number is 4 digits
            if (input < 1000 || input > 9999) 
                return -1;            

            // Check if number has at least 2 different digits
            if (input.ToString().Distinct().Count() < 2)
                return 0;
            
            int count = 0;
            int result = input;           

            while (result != 6174)
            {
                count++;
                result = (ConvertToDescending(result) - ConvertToAscending(result));
            }

            return count;
        }

        static int LargestKaprekar()
        {
            var kapDict = new Dictionary<int, int>();

            for (int i = 1000; i < 10000; i++) {
                kapDict.Add(i, Kaprekar(i));
            }

            var items = from pair in kapDict
                        orderby pair.Value descending
                        select pair;

            var largestKap = items.ElementAt(0);

            return largestKap.Value;
        }        
    }
}