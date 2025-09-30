using Tyuiu.PashkovGV.Sprint1.Task6.V2.Lib;
namespace Tyuiu.PashkovGV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string ere = "Hello World!";
            var res = ds.CheckHello(ere);
            Assert.AreEqual(true, res);

        }
    }
}
