namespace AdventOfCode.Solutions.Challenges2015
{
    public class NotQuiteLisp
    {
        public static int CalculateFinalFloor(string input)
        {
            var floor = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else if (input[i] == ')')
                {
                    floor--;
                }
            }

            return floor;
        }

        public static int CharacterPositionOfFirstBasementLanding(string input)
        {
            var position = 0;
            var floor = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else if (input[i] == ')')
                {
                    floor--;
                }

                if (floor == -1)
                {
                    position = i + 1;
                    break;
                }
            }

            return position;
        }
    }
}
