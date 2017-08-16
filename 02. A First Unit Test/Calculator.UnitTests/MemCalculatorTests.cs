using Calculator.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class MemCalculatorTests
    {
        [Test]
        [Category("Calculator")]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = CreateCalculator();
            int sum = calc.Sum();
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Add_WhenCalled_ChangeSum()
        {
            MemCalculator calc = CreateCalculator();
            calc.Add(1);
            int sum = calc.Sum();
            Assert.AreEqual(1, sum);
        }

        public MemCalculator CreateCalculator()
        {
            return new MemCalculator();
        }
    }
}
