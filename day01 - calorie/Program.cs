/*using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace day1cal
{
    public class cal
    { 
        static readonly string elfCalData = @"C:\Aamir - Silverwing\Advent of Code\day01 - calorie\day1cal\elfCalData.txt";

        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(elfCalData);
            string line;
            int currentVal = 0;
            int biggestYet = 0;
            
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                    currentVal = 0;
                else
                {
                    currentVal += Convert.ToInt32(line);
                    if (currentVal > biggestYet)
                        biggestYet = currentVal;
                }
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine(biggestYet);
        }
    }
}*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1cal
{
    public class Program2
    {
        static readonly string elfCalData = @"C:\Aamir - Silverwing\Advent of Code\day01 - calorie\day1cal\elfCalData.txt";

        public static void Main(string[] args)
        {
            List<int> elfTotalCals = new List<int>();
            StreamReader sr = new StreamReader(elfCalData);
            string line;
            int currentVal = 0;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                {
                    elfTotalCals.Add(currentVal);
                    currentVal = 0;
                }
                else
                {
                    currentVal += Convert.ToInt32(line);
                }
            }
            elfTotalCals.Add(currentVal);
            sr.Close();

            elfTotalCals.Sort((a, b) => b.CompareTo(a));
            var top3 = elfTotalCals.Take(3);
            //Console.WriteLine(top3);
            //for (int i = 0; i < 3; i++)
            //      Console.WriteLine(elfTotalCals[i]);
            int top3Total = top3.Sum();
            Console.WriteLine(top3Total);

#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}
