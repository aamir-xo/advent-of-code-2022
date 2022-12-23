using System;
using System.IO;

/*namespace day2
{
    public class rockpaper {

        static readonly string inputData = @"C:\Aamir - Silverwing\Advent of Code\day02 - rock_paper_scissors\day02rockPaper\my_input.txt";
        public static void Main(string[] args) {

            StreamReader sr = new StreamReader(inputData);
            string line;
            char opponentHand;
            char playerHand;
            int totalScore = 0;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while((line = sr.ReadLine()) != null) {
                opponentHand = line[0];
                playerHand = line[2];

                switch (playerHand) {
                    case 'X':
                        totalScore += 1;
                        if (opponentHand == 'A') {
                            totalScore += 3;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 0;
                        }
                        else {
                            totalScore += 6;
                        }
                        break;
                    case 'Y':
                        totalScore += 2;
                        if (opponentHand == 'A') {
                            totalScore += 6;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 3;
                        }
                        else {
                            totalScore += 0;
                        }
                        break;
                    case 'Z':
                        totalScore += 3;
                        if (opponentHand == 'A') {
                            totalScore += 0;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 6;
                        }
                        else {
                            totalScore += 3;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(totalScore);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}*/

namespace day2 {
    public class rockpaper1 {

        static readonly string inputData = @"C:\Aamir - Silverwing\Advent of Code\day02 - rock_paper_scissors\day02rockPaper\my_input.txt";
        public static void Main(string[] args) {

            StreamReader sr = new StreamReader(inputData);
            string line;
            char opponentHand;
            char playerHand;
            int totalScore = 0;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((line = sr.ReadLine()) != null) {
                opponentHand = line[0];
                playerHand = line[2];

                switch (playerHand) {
                    case 'X':
                        totalScore += 0;
                        if (opponentHand == 'A') {
                            totalScore += 3;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 1;
                        }
                        else {
                            totalScore += 2;
                        }
                        break;
                    case 'Y':
                        totalScore += 3;
                        if (opponentHand == 'A') {
                            totalScore += 1;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 2;
                        }
                        else {
                            totalScore += 3;
                        }
                        break;
                    case 'Z':
                        totalScore += 6;
                        if (opponentHand == 'A') {
                            totalScore += 2;
                        }
                        else if (opponentHand == 'B') {
                            totalScore += 3;
                        }
                        else {
                            totalScore += 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(totalScore);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}