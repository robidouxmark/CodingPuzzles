using AdventOfCode.Solutions.Challenges2015;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class NotQuiteLispTests
    {
        [TestCase("(", 1, TestName = "OneLeftParenReturnsOne")]
        [TestCase("((", 2, TestName = "TwoLeftParenReturnsTwo")]
        [TestCase("(((", 3, TestName = "ThreeLeftParenReturnsThree")]
        [TestCase("((((((((((", 10, TestName = "TenLeftParenReturnsTen")]
        public void LeftParenIncreasesFinalFloor(string input, int expectedOutput)
        {
            var result = NotQuiteLisp.CalculateFinalFloor(input);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestCase(")", -1, TestName = "OneRightParenReturnsNegativeOne")]
        [TestCase("))", -2, TestName = "TwoRightParenReturnsNegativeTwo")]
        [TestCase(")))", -3, TestName = "ThreeRightParenReturnsNegativeThree")]
        [TestCase("))))))))))", -10, TestName = "TenRightParenReturnsNegativeTen")]
        public void RightParenDescreasesFinalFloor(string input, int expectedOutput)
        {
            var result = NotQuiteLisp.CalculateFinalFloor(input);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestCase("))(", -1, TestName = "OneMoreRightParenReturnsNegativeOne")]
        [TestCase("))()()())(", -2, TestName = "TwoMoreRightParensReturnsNegativeTwo")]
        [TestCase("(()()(())", 1, TestName = "OneMoreLeftParenReturnsOne")]
        [TestCase("(((())))((", 2, TestName = "TwoMoreLeftParensReturnsTwo")]
        public void UnequalMixedParensReturnsNonZeroFinalFloor(string input, int expectedOutput)
        {
            var result = NotQuiteLisp.CalculateFinalFloor(input);

            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void EqualMixedParensReturnsZeroFloor()
        {
            var result = NotQuiteLisp.CalculateFinalFloor("))((");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void EmptyStringReturnsZeroFloor()
        {
            var result = NotQuiteLisp.CalculateFinalFloor("");

            Assert.AreEqual(0, result);
        }

        [TestCase(")", 1, TestName = "SingleRightParenGetsToBasementOnCharacterOne")]
        [TestCase(")()())))(((()(()))()()", 1, TestName = "LeadingRightParenGetsToBasementOnCharacterOne")]
        [TestCase("(()))", 5, TestName = "CalculateFirstLandingReturnsCharacterPositionOfFirstNegativeFloor")]
        public void CharacterPositionOfFirstBasementLandingReturnsCorrectCharacterPosition(string input, int expectedOutput)
        {
            var result = NotQuiteLisp.CharacterPositionOfFirstBasementLanding(input);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestCase("(", TestName = "SingleLeftParenRetrunsZero")]
        [TestCase("((((((", TestName = "MultipleLeftParenReturnsZero")]
        [TestCase("(((((()))", TestName = "NeverReachingBasementReturnsZero")]
        public void CharacterPositionOfFirstBasementLandingReturnsZeroWhenNeverGettingToBasement(string input)
        {
            var result = NotQuiteLisp.CharacterPositionOfFirstBasementLanding(input);

            Assert.AreEqual(0, result);
        }
    }
}
