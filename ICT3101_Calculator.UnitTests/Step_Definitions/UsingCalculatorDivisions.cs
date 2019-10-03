using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private double _result;
        private Calculator _calculator;

        public UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheResultShouldBeInfinity()
        {
            Assert.True(double.IsInfinity(_result));
        }

        [Then(@"the division result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
