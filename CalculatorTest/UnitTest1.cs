using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    //private readonly calculator calc;
    [TestClass]
    public class UnitTest1
    {
        //  calculator cal;
        //public UnitTest1()
        // {
        //     cal = new Calculator.calculator();
        // }
        calculator cal = new calculator();
        [TestMethod]
        
        public void TestAddMethod1()
        {
            
            int res = cal.Add(5,10);
            Assert.AreEqual(res,15);
        }
        public void TestSubtractMethod1()
        {
            
            int res = cal.Subtract(10, 15);
            Assert.AreEqual(res, 5);

        }
    }
}