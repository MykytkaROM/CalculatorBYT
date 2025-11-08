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
    }
}