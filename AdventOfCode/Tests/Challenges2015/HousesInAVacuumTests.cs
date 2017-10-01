using NUnit.Framework;
using AdventOfCode.Solutions.Challenges2015;

namespace AdventOfCode.Tests.Challenges2015
{
    [TestFixture]
    class HousesInAVacuumTests
    {
        [TestCase("^^^^", 5, TestName = "MovingOnlyNorthReturnsLengthOfInput")]
        [TestCase("vvvv", 5, TestName = "MovingOnlySouthReturnsLengthOfInput")]
        [TestCase(">>>>", 5, TestName = "MovingOnlyEastReturnsLengthOfInput")]
        [TestCase("<<<<", 5, TestName = "MovingOnlyWestReturnsLengthOfInput")]
        public void InputContainingOnlyOneDirectionReturnsCorrectNumberOfStops(string input, int expectedResult)
        {
            var result = HousesInAVacuum.UniqueStopsMade(input, 1);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("^>^>^>^>^>^>^^^^", 17)]
        [TestCase("vvvv>>>^^^^^^^<<<^^^^^^^^^^^", 29)]
        [TestCase(">>>>v>v>v", 10)]
        [TestCase("<<<<vvvvvv>>>", 14)]
        public void InputNotLoopingBackReturnsCorrectNumberOfStops(string input, int expectedResult)
        {
            var result = HousesInAVacuum.UniqueStopsMade(input, 1);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("^v^v", 2, TestName = "OnlyMovingNorthAndSouthReturnsTwoStops")]
        [TestCase("><><", 2, TestName = "OnlyMovingNorthAndSouthReturnsTwoStops")]
        [TestCase("^v<><>^v", 3, TestName = "ReturningToPreviouslyVisitedStopsDoesNotIncreaseStops")]
        public void ReturningToPreviousLocationsDoesNotIncreaseUniqueCount(string input, int expectedResult)
        {
            var result = HousesInAVacuum.UniqueStopsMade(input, 1);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("^>v<", 4, TestName = "CircleOfRadiusOneReturnsFourStops")]
        [TestCase("^>v<^>v<", 4, TestName = "TwoCirclesOfRadiusOneReturnsFourStops")]
        [TestCase("^>v<^>v<^>v<", 4, TestName = "ThreeCirclesOfRadiusOneReturnsFourStops")]
        [TestCase("^>v<^>v<^>v<^>v<^>v<^>v<^>v<^>v<^>v<", 4, TestName = "MultipleCirclesOfRadiusOneReturnsFourStops")]
        public void InputContainingOnlyCirclesReturnsCorrectNumberOfStops(string input, int expectedResult)
        {
            var result = HousesInAVacuum.UniqueStopsMade(input, 1);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void MixdDirectionsRetrunsCorrectNumberOfUniqueLocationsVisited()
        { 
            var result = HousesInAVacuum.UniqueStopsMade("^>^<>vv>>^<<^>v<>v<^><<v<^<^<^^^^><^><v^><^>", 1);
            
            Assert.AreEqual(25, result);
        }

        [TestCase("^^>>vv<<", 2, 4, TestName = "DoubleSymbolsMakesSecondTravelerFollowFirst")]
        [TestCase("^>^<>vv>>^<<^>v<>v<^><<v<^<^<^^^^><^><v^><^>", 2, 23, TestName = "MultipleTravelersCrossingPathsDoesNotIncreaseCount")]
        public void AddingASecondTravelerChangesUniqueCount(string input, int numTravelers, int expectedResult)
        {
            var result = HousesInAVacuum.UniqueStopsMade(input, numTravelers);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
