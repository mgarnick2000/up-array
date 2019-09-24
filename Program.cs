using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;
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
            // var num = new int[] { 0, 7, 4, 7, 5 };
            var num = new int[] { 1, 3};
            // var num = new int[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7, -3, 2, 1, 4, 7, 4, 8, 3, 6, 4, 8 };
            // var num = new int[] { -3, 2, 1, 4, 7, 4, 8, 3, 6, 4, 8 };
            UpArray(num);
        }

        static int[] UpArray(int[] num)
        {
            int addone = 1;
            int[] result;
            int value;
            string number_string = string.Join("", num);
            // WriteLine(number_string);
            string remove = Regex.Replace(number_string, @"-(\d)", "");
            // WriteLine(remove);

            bool containsNegative = num.Any(i => i < 0);
            bool zeroVal = remove.StartsWith("0");
            

            if (zeroVal)
            {
                int last = remove.Length - 1;
                char alt = remove[last];
                int lastval = Convert.ToInt32(alt - 48) + addone;
                char f = Convert.ToChar(lastval.ToString());
                string str = remove.Replace(alt, f);
                WriteLine(str);
                List<int> convert = new List<int>();
                for (int c = 0; c < str.Length; c++)
                {

                    convert.Add(str[c] - 48);
                }
                // int last = convert.Find(x => x == convert[convert.Count - 1]);
                // int total = last + addone;
                // WriteLine(total);
                // int secondLast = convert.FindIndex(0, x => x == convert[convert.Count - 1]);
                // convert.RemoveAt(secondLast);
                // WriteLine(secondLast);
                result = convert.ToArray();
            }



            if (num.Length == 0 )
            {
                WriteLine("num.Length == 0");
                return null;
            }
            else if (num.Length < 3)
            {
                WriteLine("num.Length < 3");
                value = Int32.Parse(number_string);
                int total = value + addone;
                result = Array.ConvertAll(total.ToString().ToArray(), x => (int)x - 48);
            }
            else if (num.Length < 15 && num.Length > 1 && !zeroVal)
            {
                WriteLine("num.Length < 15 && num.Length > 1 && !zeroVal");;
                value = Convert.ToInt32(remove);
                int total = value + addone;
                result = Array.ConvertAll(total.ToString().ToArray(), x => (int)x - 48);
            }
            else if ( num.Length < 15 && !zeroVal) {
                WriteLine("num.Length < 15 && !zeroVal");
                int last = remove.Length - 1;
                char alt = remove[last];
                int lastval = Convert.ToInt32(alt - 48) + addone;
                char f = Convert.ToChar(lastval.ToString());
                string str = remove.Replace(alt, f);
                result = Array.ConvertAll(str.ToArray(), x => (int)x - 48);
            }
            else if (num.Length > 18 && num.Length < 20 && !zeroVal)
            {
                WriteLine("num.Length > 18 && num.Length < 20 && !zeroVal && !containsSpecial");
                int last = remove.Length - 1;
                char alt = remove[last];
                int lastval = Convert.ToInt32(alt - 48) + addone;
                char f = Convert.ToChar(lastval.ToString());
                string str = remove.Replace(alt, f);
                result = Array.ConvertAll(str.ToArray(), x => (int)x - 48);
            }
            else
            {
                int last = remove.Length - 1;
                char alt = remove[last];
                int lastval = Convert.ToInt32(alt - 48) + addone;
                char f = Convert.ToChar(lastval.ToString());
                string str = remove.Replace(alt, f);
                WriteLine(str);
                WriteLine("BigArray");
                result = Array.ConvertAll(str.ToArray(), x => (int)x - 48);
            }

            foreach (int r in result)
            {
                WriteLine(r);
            }

            return result;

        }

    }
}
