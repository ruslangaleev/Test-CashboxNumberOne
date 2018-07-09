using CreditCalculation.Models;
using System;

namespace CreditCalculation.Services
{
    public class Calculation
    {
        /// <summary>
        /// Рассчитает ежемесячную сумму кредита.
        /// </summary>
        /// <param name="sum">Сумма кредита.</param>
        /// <param name="termType">Тип срока.</param>
        /// <param name="termValue">Значение срока.</param>
        /// <param name="rateType">Тип ставки.</param>
        /// <param name="rateValue">Значение ставки.</param>
        public double Calculate(double sum, TermType termType, int termValue, RateType rateType, double rateValue)
        {
            // TODO: Сделать рассчет срока по дням
            // TODO: Сделать рассчет по ежедневным ставкам

            if (sum < 0 )
            {
                throw new ArgumentException("Сумма кредита не должна быть менее 0.", nameof(sum));
            }

            if (termValue < 0)
            {
                throw new ArgumentException("Срок кредита не должен быть менее 0.", nameof(termValue));
            }

            if (rateValue < 0)
            {
                throw new ArgumentException("Процентная ставка не должна быть менее 0.", nameof(rateValue));
            }

            var i = (rateValue / 12) / 100;

            var k = (i * Math.Pow((1 + i), termValue)) / (Math.Pow((1 + i), termValue) - 1);

            var a = k * sum;

            return Math.Round(a, 2);
        }
    }
}