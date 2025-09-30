using Tyuiu.PashkovGV.Sprint1.Task1.V18.Lib;

namespace Tyuiu.PashkovGV.Sprint1.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3, 3);

            Assert.AreEqual(-0.75, res);
        }
    }
}