//Problem 1 Attempt 1 (Working)
/*using System;
using System.IO;

#pragma warning disable CS8600
namespace day03 {
    public class rucksack {
        static readonly string inputData = @"C:\Aamir - Silverwing\Advent of Code\day03 - rucksack\my_input.txt";

        public static void Main(string[] args) {
            StreamReader sr = new StreamReader(inputData);
            string line, Half1, Half2;
            int prioritySum = 0;
            int priority = 0;
            List<int> priorityList = new List<int>();

            while ((line = sr.ReadLine()) != null) {
                Half1 = line.Substring(0, (int)(line.Length / 2));
                Half2 = line.Substring((int)(line.Length / 2),(int)(line.Length / 2));
                char[] h1ch = new char[Half1.Length];
                char[] h2ch = new char[Half2.Length];

                for (int l = 0; l < Half1.Length; l++) {
                    h1ch[l] = Half1[l];
                    h2ch[l] = Half2[l];
                }

                h1ch = h1ch.Distinct().ToArray();
                h2ch = h2ch.Distinct().ToArray();

                for(int i = 0; i < h1ch.Length; i++) {
                    for(int j = 0; j < h2ch.Length; j++) {
                        if(h1ch[i] == h2ch[j]) {
                            if (((int)h1ch[i]) > 96) {
                                priority = ((int)h1ch[i]) - 96;
                            }
                            else {
                                priority = ((int)h1ch[i]) - 38;
                            }
                            priorityList.Add(priority);
                            //break;
                        }
                    }
                }
            }
            //List<int> noDupes = priorityList.Distinct().ToList();
            prioritySum = priorityList.Sum();
            Console.WriteLine(prioritySum);
        }
    }
}*/

/*
//Problem 1 Attempt 2 (Working)
using System;
using System.Globalization;
using System.IO;

#pragma warning disable CS8600
namespace day03 {
    public class rucksack {
        static readonly string inputData = @"C:\Aamir - Silverwing\Advent of Code\day03 - rucksack\my_input.txt";

        public static void Main(string[] args) {
            StreamReader sr = new StreamReader(inputData);
            string line, Half1, Half2;
            int priority = 0;
            
            while ((line = sr.ReadLine()) != null) {
                Half1 = line.Substring(0, (int)(line.Length / 2));
                Half2 = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));

                char[] h1ch= Half1.ToCharArray().Distinct().ToArray();
                char[] h2ch= Half2.ToCharArray().Distinct().ToArray();

                IEnumerable<char> same = h1ch.Intersect(h2ch);

                foreach (char ch in same) {
                    if (((int)ch) > 'a') {
                        priority += ((int)ch) - ((int)'a') + 1;
                    }
                    else {
                        priority += ((int)ch) - ((int)'A') + 27;
                    }
                }
            }
            Console.WriteLine(priority);
        }
    }
}*/


// Problem 2
using System;
using System.Globalization;
using System.IO;

#pragma warning disable CS8600
#pragma warning disable CS8602
namespace day03 {
    public class rucksack1 {
        static readonly string inputData = @"C:\Aamir - Silverwing\Advent of Code\day03 - rucksack\my_input.txt";

        public static void Main(string[] args) {
            StreamReader sr = new StreamReader(inputData);
            string line;
            int priority = 0;

            while ((line = sr.ReadLine()) != null) {
                char[] arr1 = line.ToCharArray();

                line = sr.ReadLine();
                char[] arr2 = line.ToCharArray();
                IEnumerable<char> same = arr1.Intersect(arr2);

                line = sr.ReadLine();
                arr1 = line.ToCharArray();
                same = same.Intersect(arr1);
                //char[] arr3 = line.ToCharArray();
                //IEnumerable<char> same = arr1.Intersect(arr2).Intersect(arr3);

                foreach (char ch in same) {
                    if (((int)ch) > 'a') {
                        priority += ((int)ch) - ((int)'a') + 1;
                    }
                    else {
                        priority += ((int)ch) - ((int)'A') + 27;
                    }
                }
            }
            Console.WriteLine(priority);
        }
    }
}