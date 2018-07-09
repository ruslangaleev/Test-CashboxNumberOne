using CreditCalculation.Models;
using CreditCalculation.Services;
using NUnit.Framework;
namespace CreditCalculationTests
{
    [TestFixture]
    public class CalculationTests
    {
        Calculation _calculation;

        [SetUp]
        public void Setup()
        {
            _calculation = new Calculation();
        }

        [Test]
        public void ReturnsSumMonthlyWithYearlyRate()
        {
            // Действие.
            var result = _calculation.Calculate(30000, TermType.Month, 36, RateType.Year, 18);

            // Проверка.
            Assert.AreEqual(1084.57, result);
        }
    }
}
