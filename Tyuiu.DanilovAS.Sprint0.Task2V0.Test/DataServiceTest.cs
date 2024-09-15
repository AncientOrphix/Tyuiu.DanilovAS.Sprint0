using Tyuiu.DanilovAS.Sprint0.Task2V0.Lib;
namespace Tyuiu.DanilovAS.Sprint0.Task2V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Александр";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Александр",res);
        }
    }
}