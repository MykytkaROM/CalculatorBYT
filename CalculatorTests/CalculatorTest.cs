using Calculator;
namespace CalculatorTests;

{
    public class Tests
    {
         [Test]
         public void TestCalculatorNotMathOpperator()
         {
            
         }
        [Test]
        public void TestCalculatorMissingOpperator()
        {

        }

        [Test]
        public void TestCalculatorAddition()
        {
            var calc = new Calculator.Calculator(5,4,"+"); 
            
        }
    }
}