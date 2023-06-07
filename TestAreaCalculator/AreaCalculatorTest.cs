using System;
using AreaCalculator;

namespace TestAreaCalculator
{
    public class AreaCalculatorTest : IDisposable
    {
        Area testCase;
        public AreaCalculatorTest()
        {
            testCase = new Area();
        }
        public void Dispose()
        {
            
        }

        [Fact]
        public void TestCalculateCircleIsCorrect()
        {
            double radius = 33.324;
            double expected = 3488.7;

            double actual = Math.Round(testCase.CalculateCircle(radius), 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculateTriangleIsCorrect()
        {
            double a = 30.0;
            double b = 40.0;
            double c = 50.0;
            double expected = 600;

            double actual = testCase.CalculateTriangle(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}