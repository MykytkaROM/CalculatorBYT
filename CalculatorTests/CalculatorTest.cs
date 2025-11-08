using Calculator;
namespace CalculatorTests
{
    public class Tests
    {
         [Test]
         public void TestCalculatorNotMathOpperator()
         {
            var calc = new Calculator.Calculator(5, 4, ")");
            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }
        
        [Test]
        public void TestCalculatorAddition()
        {
            var calc = new Calculator.Calculator(5,4,"+"); 
            Assert.That(calc.Calculate(), Is.EqualTo(9f));
        }
        [Test]
        public void TestCalculatorSubtraction()
        {
            var calc = new Calculator.Calculator(5, 4, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(1f));
        }
        [Test]
        public void TestCalculatorMultiplication()
        {
            var calc = new Calculator.Calculator(5, 4, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(20f));
        }
        [Test]
        public void TestCalculatorDivision()
        {
            var calc = new Calculator.Calculator(20, 10, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2f));
        }
        [Test]
        public void TestCalculatorDivisionByZero() 
        {
            var calc = new Calculator.Calculator(5, 0, "/");
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

    }
}