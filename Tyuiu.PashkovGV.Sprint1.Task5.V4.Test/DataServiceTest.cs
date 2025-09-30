using Tyuiu.PashkovGV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.PashkovGV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double time = 5382;
            double h = time / 3600;
            
            var res = Math.Round(h);
            Assert.AreEqual(1, res );
        }
    }
}
