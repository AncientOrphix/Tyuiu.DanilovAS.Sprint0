using Tyuiu.DanilovAS.Sprint0.Task5V0.Lib;

namespace Tyuiu.DanilovAS.Sprint0.Task5V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void CheckedAdditionValid()
            {
                Assert.AreEqual(10, DataService.Addition(5, 5));
            }
            public void CheckedSubtractionValid()
            {
                Assert.AreEqual(5, DataService.Subtraction(10, 5));
            }
            public void CheckedMultiplication()
            {
                Assert.AreEqual(50,DataService.Multiplication(10, 5));
            }
            public void CheckedDivisionValud()
            {
                Assert.AreEqual(3, DataService.Division(9, 3));
            }
        }
    
}