using System;
using System.IO;
using System.Text.RegularExpressions;

#pragma warning disable CS8600, CS8602, CS8601
namespace day05 {
    public class supplyStacks1 {
        static readonly string input = @"C:\Aamir - Silverwing\Advent of Code\day05 - supplyStacks\my.txt";
        public static List<List<char>> stacks = new List<List<char>>();
        public static StreamReader sr = new StreamReader(input);
        public static string line;

        public static void extractStackValues() {

            //--->adding values to stacks
            while ((line = sr.ReadLine()) != "") {
                for (int k = 0; k < line.Length; k++) {
                    if (k % 4 == 0) {
                        try {
                            stacks[k / 4].Add(line[k + 1]);
                        }
                        catch (ArgumentOutOfRangeException) {
                            stacks.Add(new List<char>());
                            stacks[k / 4].Add(line[k + 1]);
                        }
                    }
                }
            }
            //---> cleaning null and end values(column no)
            for (int i = 0; i < stacks.Count; i++) {
                stacks[i].RemoveAt(stacks[i].Count - 1);              //remove column no
                stacks[i].RemoveAll(s => char.IsWhiteSpace(s));     //remove whitespaces
                //stacks[i].ForEach(p => Console.Write(p));
                //Console.WriteLine();
            }

            return;
        }

        public static void problem1() {
            while ((line = sr.ReadLine()) != null) {
                //---> extracting move operations
                Regex regex = new Regex(@"\d+");
                var a = (regex.Matches(line));

                int move = Int32.Parse(a[0].Value);
                int from = Int32.Parse(a[1].Value) - 1;
                int to = Int32.Parse(a[2].Value) - 1;

                //---> performing move operations
                for (int q = 1; q <= move; q++) {
                    stacks[to].Insert(0, stacks[from][0]);
                    stacks[from].RemoveAt(0);
                }
                stacks[0].ForEach(p => Console.Write(p));
                Console.WriteLine();
                stacks[1].ForEach(p => Console.Write(p));
                Console.WriteLine();
                stacks[2].ForEach(p => Console.Write(p));
                Console.WriteLine();
            }
            string output = "";
            foreach (var stack in stacks) {
                output += stack[0];
            }
            Console.WriteLine(output);
        }
        
        public static void problem2() {
            while ((line = sr.ReadLine()) != null) {
                //---> extracting move operations
                Regex regex = new Regex(@"\d+");
                var a = (regex.Matches(line));

                int move = Int32.Parse(a[0].Value);
                int from = Int32.Parse(a[1].Value) - 1;
                int to = Int32.Parse(a[2].Value) - 1;
                var tempStack = new List<char>();

                //---> performing move operations
                for (int q = 1; q <= move; q++) {
                    tempStack.Insert(0, stacks[from][0]);
                    stacks[from].RemoveAt(0);
                }

                //tempStack.Reverse();
                foreach (var crate in tempStack) {
                    //stacks[to].Add(crate);
                    stacks[to].Insert(0, crate);
                }
                /*
                stacks[0].ForEach(p => Console.Write(p));
                Console.WriteLine();
                stacks[1].ForEach(p => Console.Write(p));
                Console.WriteLine();
                stacks[2].ForEach(p => Console.Write(p));
                Console.WriteLine();
                */
            }
            string output = "";
            foreach (var stack in stacks) {
                output += stack[0];
            }
            Console.WriteLine(output);
        }

        public static void Main(string[] args) {
            extractStackValues();
            problem2();
        }
    }
}