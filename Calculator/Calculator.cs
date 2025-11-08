using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private readonly float a;
        private readonly float b;
        private readonly string op;
        
        public Calculator(float a, float b, string op) 
        {
            this.a = a; this.b = b; this.op = op;
        }
        public float Calculate() {
            switch (op)
            {
                case "+":
                    return Addition(a, b);
                   
                case "-":
                   return Subtraction(a, b);
                    
                case "*":
                   return Multiplication(a, b);
                    
                case "/":
                   return Division(a, b);
                    
                default:
                    throw new Exception("Calculator requires mathematical operator");
            }
        }
        public float Addition(float a,float b) 
        {
            return a + b;
        }
        public float Subtraction(float a, float b) 
        {
            return a - b;
        }
        public float Division(float a, float b) 
        {
            if (b == 0) 
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
        public float Multiplication(float a, float b)
        {
            return a * b;
        }
    }
}
