using System;
using System.Linq;
using static System.Console;
using System.Text.RegularExpressions;
using System.Globalization;

namespace up_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // var num = new int[] { 2, 3, 9 };
            // var newNum = new int[] { 2, 4, 0 };
            // var num = new int[] { 4, 3, 2, 5 };
            // var newNum = new int[] { 4, 3, 2, 6 };
            var num = new int[] { 0, 7, 4, 7, 5 };
            // var num = new int[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7, -3, 2, 1, 4, 7, 4, 8, 3, 6, 4, 8 };
            UpArray(num);
        }

        static int[] UpArray(int[] num)
        {
            int addone = 1;
            long addLong = 1;
            int[] result;
            int value;
            long largeNum;
            string number_string = string.Join("", num);
            WriteLine(number_string);
            bool containsNegative = num.Any(i => i < 0);
            if (containsNegative)
            {
                    string remove = Regex.Replace(number_string, @"-(\d)", "");
                    value = Convert.ToInt32(remove);
            }
            else
            {
                value = Convert.ToInt32(number_string);
            }

            if (num.Length == 0 || containsNegative)
            {
                result = null;
            } else if (num.Length > 10) {
                largeNum = long.Parse(number_string);
                long total = largeNum + addLong;
                result = Array.ConvertAll(total.ToString().ToArray(), x => (int)x - 48);
            }
            else
            {
                int total = value + addone;
                result = Array.ConvertAll(total.ToString().ToArray(), x => (int)x - 48);


            }

            foreach (int r in result)
            {
                WriteLine(r);
            }

            return result;

        }

    }
}
