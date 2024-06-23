using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapApiTest
{
    internal class CalculatorTest
    {
        [Test]
        public void Calculator_Add()
        {
            var num1 = 1;
            var num2 = 2;

            var claint = new CalculatorService.CalculatorSoapClient();
            var response = claint.Add(num1, num2);

            response.Should().Be(3);
        }
    }
}
