using CreditCalculation.Models;
using CreditCalculation.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculationTests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void Test()
        {
            // Подготовка.
            var calculation = new Calculation();

            // Действие.
            var result = calculation.Calculate(30000, TermType.Month, 36, RateType.Year, 18);

            // Проверка.
            Assert.AreEqual(1084.57, result);
        }
    }
}
