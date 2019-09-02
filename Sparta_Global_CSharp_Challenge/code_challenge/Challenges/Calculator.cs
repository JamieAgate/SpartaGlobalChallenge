using System;
namespace code_challenge.Challenges
{
    public class Calculator
    {
    
        /*
        * Within this Calculator class you will need to create 4 methods.
        * The four methods will relate to the basic functions of a calculator and should be named:
        *
        *  - Add
        *  - Subtract
        *  - Multiply
        *  - Divide
        *
        * Each method accept 'int' two numbers and return the int value.
        *
        * Don't forget to look at the tests for guidance.
        *
        */

        // Implement the add function below here
        public int Add(int _num1, int _num2)
        {
            return (_num1 + _num2);
        }

        // Implement the subtract function below here
        public int Subtract(int _num1, int _num2)
        {
            return (_num1 - _num2);
        }

        // Implement the multiply function below here
        public int Multiply(int _num1, int _num2)
        {
            return (_num1 * _num2);
        }

        // Implement the divide function below here
        public int Divide(int _num1, int _num2)
        {
            return (_num1 / _num2);
        }
    }
}
