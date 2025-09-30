using Tyuiu.PashkovGV.Sprint1.Task4.V27.Lib;
namespace Tyuiu.PashkovGV.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = (1 + Math.Sin(Math.PI * x)) / (x - Math.Sqrt(Math.Abs(y)));
            Assert.AreEqual(-2.414213562373095, res);

        }
    }
}
