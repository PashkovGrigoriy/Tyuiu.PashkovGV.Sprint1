using Tyuiu.PashkovGV.Sprint1.Task3.V7.Lib;
namespace Tyuiu.PashkovGV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double verst = 5;
            var res = verst * 1.0668;
            Assert.AreEqual(5.334, res);
        }
    }
}
