using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        
        public float result;
        public Calculator(float a, float b, string op) 
        {
            switch (op)
            {
                case "+":
                    Addition(a, b);
                    break;
                case "-":
                    Subtraction(a,b);
                    break;
                case "*":
                    Multiplication(a,b);
                    break;
                case "/":
                    Division(a,b);
                    break;
                default:
                    throw new Exception("Calculator requires mathematical operator");
            }
        }
        public void Addition(float a,float b) 
        {
            
        }
        public void Subtraction(float a, float b) 
        {

        }
        public void Division(float a, float b) 
        {
            
        }
        public void Multiplication(float a, float b)
        {

        }
    }
}
