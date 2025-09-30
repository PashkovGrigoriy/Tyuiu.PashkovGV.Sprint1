using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PashkovGV.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            double rrr;
            rrr = (1 + Math.Sin(Math.PI * x)) / (x - Math.Sqrt(Math.Abs(y)));
            double a = Math.Round(rrr, 3);
            return  a;
        }
    }
}
