using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private readonly List<double> _values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 }

        [Test];
        public void Test_AverageByMean()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actual = calculator.CalculateAverageFor(_values, new AverageByMean());

            //Assert
            Assert.IsTrue(ResultsAreCloseEnough(8.3636363, actual));
        }

        [Test]
        public void Test_AverageByMedian()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actual = calculator.CalculateAverageFor(_values, new AverageByMedian());

            //Assert
            Assert.IsTrue(ResultsAreCloseEnough(8.3636363, actual));
        }

        private bool ResultsAreCloseEnough(double expectedResult, double calculatedResult)
        {
            var difference = Math.Abs(expectedResult - calculatedResult);
            return difference < .000001;
        }
    }
}
