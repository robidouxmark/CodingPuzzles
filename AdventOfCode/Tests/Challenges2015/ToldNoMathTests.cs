using AdventOfCode.Solutions.Challenges2015;
using NUnit.Framework;

namespace AdventOfCode.Tests.Challenges2015
{
    [TestFixture]
    public class ToldNoMathTests
    {
        static object[] singleBoxTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 } }, 7 },
            new object[] { new int[,] { { 1, 2, 1 } }, 11 },
            new object[] { new int[,] { { 2, 3, 4 } }, 58 },
            new object[] { new int[,] { { 10, 10, 11 } }, 740 },
            new object[] { new int[,] { { 7, 3, 4 } }, 134 },
            new object[] { new int[,] { { 3, 1, 5 } }, 49 },
            new object[] { new int[,] { { 5, 6, 7 } }, 244 }
        };

        [Test, TestCaseSource("singleBoxTestSource")]
        public void SingleBoxReturnsCorrectValue(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateTotalSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orientationTestSource =
        {
            new object[] { new int[,] { { 2, 5, 7 } }, 128 },
            new object[] { new int[,] { { 2, 7, 5 } }, 128 },
            new object[] { new int[,] { { 5, 2, 7 } }, 128 },
            new object[] { new int[,] { { 5, 7, 2 } }, 128 },
            new object[] { new int[,] { { 7, 2, 5 } }, 128 },
            new object[] { new int[,] { { 7, 5, 2 } }, 128 }
        };

        [Test, TestCaseSource("orientationTestSource")]
        public void OrientationDoesNotMatter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateTotalSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] multipleBoxTestSource =
        {       
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 } }, 65 },
            new object[] { new int[,] { { 1, 2, 1 }, { 7, 3, 4 } }, 145 },
            new object[] { new int[,] { { 2, 3, 4 }, { 10, 10, 11 } }, 798 },
            new object[] { new int[,] { { 10, 10, 11 }, { 3, 1, 5 } }, 789 },
            new object[] { new int[,] { { 7, 3, 4 }, { 1, 1, 1 } } , 141 },
            new object[] { new int[,] { { 3, 1, 5 }, { 5, 6, 7 } }, 293 },
            new object[] { new int[,] { { 5, 6, 7 }, { 1, 2, 1 } } , 255 }
        };

        [Test, TestCaseSource("multipleBoxTestSource")]
        public void MultipleBoxesReturnsCorrectValue(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateTotalSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orderTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 1, 2, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 10, 10, 11 }, { 1, 1, 1 }, { 1, 2, 1 }, { 7, 3, 4 }, { 2, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 1, 2, 1 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 1, 2, 1 }, { 2, 3, 4 }, { 5, 6, 7 }, { 10, 10, 11 }, { 1, 1, 1 }, { 7, 3, 4 }, { 3, 1, 5 } }, 1243 }
        };                              

        [Test, TestCaseSource("orderTestSource")]
        public void OrderDoesNotMatter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateTotalSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
