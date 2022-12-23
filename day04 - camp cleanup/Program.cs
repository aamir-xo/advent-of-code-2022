using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

#pragma warning disable CS8600
#pragma warning disable CS8602
namespace day04 {
    public class cleanup {
        static readonly string input = @"C:\Aamir - Silverwing\Advent of Code\day04 - camp cleanup\my.txt";
        /*
        public static int problem1() {
            StreamReader sr = new StreamReader(input);
            string line;
            int counter = 0;

            while ((line = sr.ReadLine()) != null) {
                string[] values = line.Split('-',',');

                int c1 = int.Parse(values[0]);
                int c2 = int.Parse(values[1]);
                int c3 = int.Parse(values[2]);
                int c4 = Convert.ToInt32(values[3]);

                if (c1 <= c3 && c2 >= c4) {
                    counter++;
                }
                else if (c1 >= c3 && c2 <= c4) {
                    counter++;
                }
            }

            return counter;
        }*/

        public static int problem2() {
            StreamReader sr = new StreamReader(input);
            string line;
            int counter = 0;

            while ((line = sr.ReadLine()) != null) {
                string[] values = line.Split('-', ',');

                int c1 = int.Parse(values[0]);
                int c2 = int.Parse(values[1]);
                int c3 = int.Parse(values[2]);
                int c4 = int.Parse(values[3]);

                /*if (c2 !< c3) {
                    counter++;
                }
                else if (c4 !< c1)
                    counter++;*/

                /*if (c2 >= c3) {
                    if (c3 >= c1) {
                        counter++;
                    } 
                }
                else if (c2 >= c4) {
                    if (c4 >= c1) {
                        counter++;
                    }

                }*/

                //------yt
                if (c1 <= c4 && c3 <= c2) {
                    counter++;
                }

            }

            return counter;
        }

        public static void Main(String[] args) {
            Console.WriteLine(problem2());
        }
    }
}