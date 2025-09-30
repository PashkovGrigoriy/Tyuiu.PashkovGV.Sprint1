using Tyuiu.PashkovGV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.PashkovGV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            int a = 17;
            int b = 8;
            var res = (a + b) * 2;
            Assert.AreEqual(50, res);
        }
    }
}
