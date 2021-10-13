using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int firstNum, int secNum)
        {        
            return firstNum + secNum;
        }
        public double Add(double firstNum, double secNum, double thirdNum)
        {
            return firstNum + secNum + thirdNum;
        }
        public decimal Add(decimal firstNum, decimal secNum, decimal thirdNum)
        {
            return firstNum + secNum + thirdNum;
        }


    }
}
