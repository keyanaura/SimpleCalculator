using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void Add_WhenAddingZerotoAnyNumberProducesSamenumber()
        {
            // arrange 

            var unitUnderTest = new Calculator();

            // act
            int givenNumber = 1;
            var result = unitUnderTest.Add(0, givenNumber);

            // assert
            Assert.AreEqual(result, givenNumber);
        }

        [TestMethod]
        public void Add_AddingOperand1andOperand2IsSameAsAddingOperand2andOperand1()
        {
            // arrange

            var unitUnderTest = new Calculator();

            // act
            int operand1 = 1;
            int operand2 = 2;

            var resultofAddingOperand1and2 = unitUnderTest.Add(operand1, operand2);
            var resultofAddingOperand2and1 = unitUnderTest.Add(operand2, operand1);


            // assert
            Assert.AreEqual(resultofAddingOperand1and2, resultofAddingOperand2and1);

        }


    }
}
