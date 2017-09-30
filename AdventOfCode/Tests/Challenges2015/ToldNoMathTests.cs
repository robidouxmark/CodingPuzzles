using AdventOfCode.Solutions.Challenges2015;
using NUnit.Framework;

namespace AdventOfCode.Tests.Challenges2015
{
    [TestFixture]
    public class ToldNoMathTests
    {
        static object[] singleBoxSurfaceAreaTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 } }, 7 },
            new object[] { new int[,] { { 1, 2, 1 } }, 11 },
            new object[] { new int[,] { { 2, 3, 4 } }, 58 },
            new object[] { new int[,] { { 10, 10, 11 } }, 740 },
            new object[] { new int[,] { { 7, 3, 4 } }, 134 },
            new object[] { new int[,] { { 3, 1, 5 } }, 49 },
            new object[] { new int[,] { { 5, 6, 7 } }, 244 }
        };

        [Test, TestCaseSource("singleBoxSurfaceAreaTestSource")]
        public void SingleBoxReturnsCorrectSurfaceAreaWithSlack(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orientationSurfaceAreaTestSource =
        {
            new object[] { new int[,] { { 2, 5, 7 } }, 128 },
            new object[] { new int[,] { { 2, 7, 5 } }, 128 },
            new object[] { new int[,] { { 5, 2, 7 } }, 128 },
            new object[] { new int[,] { { 5, 7, 2 } }, 128 },
            new object[] { new int[,] { { 7, 2, 5 } }, 128 },
            new object[] { new int[,] { { 7, 5, 2 } }, 128 }
        };

        [Test, TestCaseSource("orientationSurfaceAreaTestSource")]
        public void OrientationDoesNotMatterInSurfaceArea(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] multipleBoxSurfaceAreaTestSource =
        {       
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 } }, 65 },
            new object[] { new int[,] { { 1, 2, 1 }, { 7, 3, 4 } }, 145 },
            new object[] { new int[,] { { 2, 3, 4 }, { 10, 10, 11 } }, 798 },
            new object[] { new int[,] { { 10, 10, 11 }, { 3, 1, 5 } }, 789 },
            new object[] { new int[,] { { 7, 3, 4 }, { 1, 1, 1 } } , 141 },
            new object[] { new int[,] { { 3, 1, 5 }, { 5, 6, 7 } }, 293 },
            new object[] { new int[,] { { 5, 6, 7 }, { 1, 2, 1 } } , 255 }
        };

        [Test, TestCaseSource("multipleBoxSurfaceAreaTestSource")]
        public void MultipleBoxesReturnsCorrectSumOfSurfaceAreaWithSlack(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orderSurfaceAreaTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 1, 2, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 10, 10, 11 }, { 1, 1, 1 }, { 1, 2, 1 }, { 7, 3, 4 }, { 2, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 1, 2, 1 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1243 },
            new object[] { new int[,] { { 1, 2, 1 }, { 2, 3, 4 }, { 5, 6, 7 }, { 10, 10, 11 }, { 1, 1, 1 }, { 7, 3, 4 }, { 3, 1, 5 } }, 1243 }
        };                              

        [Test, TestCaseSource("orderSurfaceAreaTestSource")]
        public void OrderDoesNotMatterInSurfaceArea(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfSurfaceAreaWithSlack(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] singleBoxPerimeterTestSource =
{
            new object[] { new int[,] { { 1, 1, 1 } }, 4 },
            new object[] { new int[,] { { 1, 2, 1 } }, 4 },
            new object[] { new int[,] { { 2, 3, 4 } }, 10 },
            new object[] { new int[,] { { 10, 10, 11 } }, 40 },
            new object[] { new int[,] { { 7, 3, 4 } }, 14 },
            new object[] { new int[,] { { 3, 1, 5 } }, 8 },
            new object[] { new int[,] { { 5, 6, 7 } }, 22 }
        };

        [Test, TestCaseSource("singleBoxPerimeterTestSource")]
        public void SingleBoxReturnsCorrectPerimeter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfPerimeterOfSmallestSide(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orientationPerimeterTestSource =
        {
            new object[] { new int[,] { { 2, 5, 7 } }, 14 },
            new object[] { new int[,] { { 2, 7, 5 } }, 14 },
            new object[] { new int[,] { { 5, 2, 7 } }, 14 },
            new object[] { new int[,] { { 5, 7, 2 } }, 14 },
            new object[] { new int[,] { { 7, 2, 5 } }, 14 },
            new object[] { new int[,] { { 7, 5, 2 } }, 14 }
        };

        [Test, TestCaseSource("orientationPerimeterTestSource")]
        public void OrientationDoesNotMatterInPerimeter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfPerimeterOfSmallestSide(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] multipleBoxPerimeterTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 } }, 14 },
            new object[] { new int[,] { { 1, 2, 1 }, { 7, 3, 4 } }, 18 },
            new object[] { new int[,] { { 2, 3, 4 }, { 10, 10, 11 } }, 50 },
            new object[] { new int[,] { { 10, 10, 11 }, { 3, 1, 5 } }, 48 },
            new object[] { new int[,] { { 7, 3, 4 }, { 1, 1, 1 } } , 18 },
            new object[] { new int[,] { { 3, 1, 5 }, { 5, 6, 7 } }, 30 },
            new object[] { new int[,] { { 5, 6, 7 }, { 1, 2, 1 } } , 26 }
        };

        [Test, TestCaseSource("multipleBoxPerimeterTestSource")]
        public void MultipleBoxesReturnsCorrectSumOfPerimeter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfPerimeterOfSmallestSide(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orderPerimeterTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 1, 2, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 102 },
            new object[] { new int[,] { { 10, 10, 11 }, { 1, 1, 1 }, { 1, 2, 1 }, { 7, 3, 4 }, { 2, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 102 },
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 1, 2, 1 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 102 },
            new object[] { new int[,] { { 1, 2, 1 }, { 2, 3, 4 }, { 5, 6, 7 }, { 10, 10, 11 }, { 1, 1, 1 }, { 7, 3, 4 }, { 3, 1, 5 } }, 102 }
        };

        [Test, TestCaseSource("orderPerimeterTestSource")]
        public void OrderDoesNotMatterInPerimeter(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfPerimeterOfSmallestSide(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] singleBoxVolumeTestSource =
{
            new object[] { new int[,] { { 1, 1, 1 } }, 1 },
            new object[] { new int[,] { { 1, 2, 1 } }, 2 },
            new object[] { new int[,] { { 2, 3, 4 } }, 24 },
            new object[] { new int[,] { { 10, 10, 11 } }, 1100 },
            new object[] { new int[,] { { 7, 3, 4 } }, 84 },
            new object[] { new int[,] { { 3, 1, 5 } }, 15 },
            new object[] { new int[,] { { 5, 6, 7 } }, 210 }
        };

        [Test, TestCaseSource("singleBoxVolumeTestSource")]
        public void SingleBoxReturnsCorrectVolume(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfVolume(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orientationVolumeTestSource =
        {
            new object[] { new int[,] { { 2, 5, 7 } }, 70 },
            new object[] { new int[,] { { 2, 7, 5 } }, 70 },
            new object[] { new int[,] { { 5, 2, 7 } }, 70 },
            new object[] { new int[,] { { 5, 7, 2 } }, 70 },
            new object[] { new int[,] { { 7, 2, 5 } }, 70 },
            new object[] { new int[,] { { 7, 5, 2 } }, 70 }
        };

        [Test, TestCaseSource("orientationVolumeTestSource")]
        public void OrientationDoesNotMatterInVolume(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfVolume(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] multipleBoxVolumeTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 } }, 25 },
            new object[] { new int[,] { { 1, 2, 1 }, { 7, 3, 4 } }, 86 },
            new object[] { new int[,] { { 2, 3, 4 }, { 10, 10, 11 } }, 1124 },
            new object[] { new int[,] { { 10, 10, 11 }, { 3, 1, 5 } }, 1115 },
            new object[] { new int[,] { { 7, 3, 4 }, { 1, 1, 1 } } , 85 },
            new object[] { new int[,] { { 3, 1, 5 }, { 5, 6, 7 } }, 225 },
            new object[] { new int[,] { { 5, 6, 7 }, { 1, 2, 1 } } , 212 }
        };

        [Test, TestCaseSource("multipleBoxVolumeTestSource")]
        public void MultipleBoxesReturnsCorrectSumOfVolume(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfVolume(input);

            Assert.AreEqual(expectedValue, result);
        }

        static object[] orderVolumeTestSource =
        {
            new object[] { new int[,] { { 1, 1, 1 }, { 1, 2, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1436 },
            new object[] { new int[,] { { 10, 10, 11 }, { 1, 1, 1 }, { 1, 2, 1 }, { 7, 3, 4 }, { 2, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1436 },
            new object[] { new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 10, 10, 11 }, { 1, 2, 1 }, { 7, 3, 4 }, { 3, 1, 5 }, { 5, 6, 7 } }, 1436 },
            new object[] { new int[,] { { 1, 2, 1 }, { 2, 3, 4 }, { 5, 6, 7 }, { 10, 10, 11 }, { 1, 1, 1 }, { 7, 3, 4 }, { 3, 1, 5 } }, 1436 }
        };

        [Test, TestCaseSource("orderVolumeTestSource")]
        public void OrderDoesNotMatterInVolume(int[,] input, int expectedValue)
        {
            var result = ToldNoMath.CalculateSumOfVolume(input);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
