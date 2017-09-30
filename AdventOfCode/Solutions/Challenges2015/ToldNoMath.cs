namespace AdventOfCode.Solutions.Challenges2015
{
    public class ToldNoMath
    {
        public static int CalculateSumOfSurfaceAreaWithSlack(int[,] boxes)
        {
            var totalSurfaceArea = 0;

            for (var row = 0; row < boxes.Length / 3; row++)
            {
                ArrangeBoxOnSmallestSide(boxes, row);

                totalSurfaceArea += 2 * (boxes[row, 0] * boxes[row, 1] + boxes[row, 0] * boxes[row, 2] + boxes[row, 1] * boxes[row, 2]) + boxes[row, 0] * boxes[row, 1];
            }

            return totalSurfaceArea;
        }

        public static int CalculateSumOfPerimeterOfSmallestSide(int[,] boxes)
        {
            var perimeterSum = 0;

            for (var row = 0; row < boxes.Length / 3; row++)
            {
                ArrangeBoxOnSmallestSide(boxes, row);

                perimeterSum += 2 * (boxes[row, 0] + boxes[row, 1]);
            }

            return perimeterSum;
        }


        public static int CalculateSumOfVolume(int[,] boxes)
        {
            var volumeSum = 0;

            for (var row = 0; row < boxes.Length / 3; row++)
            {
                volumeSum += boxes[row, 0] * boxes[row, 1] * boxes[row, 2];
            }

            return volumeSum;
        }

        private static void ArrangeBoxOnSmallestSide(int[,] boxes, int boxNumber)
        {
            if (boxes[boxNumber, 0] < boxes[boxNumber, 1])
            {
                //0 < 1
                if (boxes[boxNumber, 1] > boxes[boxNumber, 2])
                {
                    //2 < 1
                    var temp = boxes[boxNumber, 1];
                    boxes[boxNumber, 1] = boxes[boxNumber, 2];
                    boxes[boxNumber, 2] = temp;
                }
            }
            else
            {
                //1 <= 0
                if (boxes[boxNumber, 0] > boxes[boxNumber, 2])
                {
                    //2 < 0
                    var temp = boxes[boxNumber, 0];
                    boxes[boxNumber, 0] = boxes[boxNumber, 2];
                    boxes[boxNumber, 2] = temp;
                }
            }
        }
    }
}
