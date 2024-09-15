using Tyuiu.DanilovAS.Sprint0.Task3V0.Lib;

namespace Tyuiu.DanilovAS.Sprint0.Task3V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}