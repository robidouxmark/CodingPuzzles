using System;
using System.IO;
using AdventOfCode.Solutions.Challenges2015;

namespace AdventOfCode.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var DayOneInput = File.ReadAllText($"Inputs\\{nameof(NotQuiteLisp)}.txt");
            Console.WriteLine($"The solution to Day 1 Part One is: {NotQuiteLisp.CalculateFinalFloor(DayOneInput)}");
            Console.WriteLine($"The solution to Day 1 Part Two is: {NotQuiteLisp.CharacterPositionOfFirstBasementLanding(DayOneInput)}");

            var DayTwoInput = File.ReadAllLines($"Inputs\\{nameof(ToldNoMath)}.txt");
            var boxes = ParseDayTwoInput(DayTwoInput);
            Console.WriteLine($"The solution to Day 2 Part One is: {ToldNoMath.CalculateSumOfSurfaceAreaWithSlack(boxes)}");
            Console.WriteLine($"The solution to Day 2 Part Two is: {ToldNoMath.CalculateSumOfPerimeterOfSmallestSide(boxes) + ToldNoMath.CalculateSumOfVolume(boxes)}");

            Console.ReadLine();
        }

        static int[,] ParseDayTwoInput(string[] input)
        {
            var boxes = new int[input.Length, 3];

            for (var row = 0; row < input.Length; row++)
            {
                var dimensions = input[row].Split('x');

                boxes[row, 0] = Convert.ToInt32(dimensions[0]);
                boxes[row, 1] = Convert.ToInt32(dimensions[1]);
                boxes[row, 2] = Convert.ToInt32(dimensions[2]);
            }

            return boxes;
        }
    }
}
