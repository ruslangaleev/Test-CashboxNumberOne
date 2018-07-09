using CreditCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCalculation.Services
{
    public class Calculation
    {
        /// <summary>
        /// Рассчитает ежемесячную сумму кредита.
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="termType"></param>
        /// <param name="termValue"></param>
        /// <param name="rateType"></param>
        /// <param name="rateValue"></param>
        /// <returns></returns>
        public double Calculate(double sum, TermType termType, int termValue, RateType rateType, double rateValue)
        {
            var i = (rateValue / 12) / 100;

            var k = (i * Math.Pow((1 + i), termValue)) / (Math.Pow((1 + i), termValue) - 1);

            var a = k * sum;

            return Math.Round(a, 2);
        }
    }
}