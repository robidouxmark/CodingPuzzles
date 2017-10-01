namespace AdventOfCode.Solutions.Challenges2015
{
    public class HousesInAVacuum
    {
        public static int UniqueStopsMade(string input, int numTravelers)
        {
            var houses = new bool[2 * input.Length + 1, 2 * input.Length + 1];
            var uniqueHouses = 1;
            houses[input.Length, input.Length] = true;
            var travelerXCoord = new int[numTravelers];
            var travelerYCoord = new int[numTravelers];
            for (var i = 0; i < numTravelers; i++)
            {
                travelerXCoord[i] = input.Length;
                travelerYCoord[i] = input.Length;            
            }
            var currentTraveller = 0;

            for(var i = 0; i< input.Length; i++)
            {
                switch (input[i])
                {
                    case '^':
                        travelerYCoord[currentTraveller]++;
                        break;
                    case '>':
                        travelerXCoord[currentTraveller]++;
                        break;
                    case 'v':
                        travelerYCoord[currentTraveller]--;
                        break;
                    case '<':
                        travelerXCoord[currentTraveller]--;
                        break;                   
                }

                if (houses[travelerXCoord[currentTraveller], travelerYCoord[currentTraveller]] == false)
                {
                    houses[travelerXCoord[currentTraveller], travelerYCoord[currentTraveller]] = true;
                    uniqueHouses++;
                }

                currentTraveller = (currentTraveller + 1) % numTravelers;
            }

            return uniqueHouses;
        }
    }
}
