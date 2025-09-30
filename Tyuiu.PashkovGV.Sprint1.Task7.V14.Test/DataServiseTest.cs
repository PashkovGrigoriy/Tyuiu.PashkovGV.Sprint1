using Tyuiu.PashkovGV.Sprint1.Task7.V14.Lib;
namespace Tyuiu.PashkovGV.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(0.87, res);
        }
    }
}
