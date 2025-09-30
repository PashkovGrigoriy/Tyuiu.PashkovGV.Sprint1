using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PashkovGV.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            double rounded;
            verst = verst * 1.0668;
            rounded = Math.Round(verst, 3);
            verst = rounded;
            return verst; 
            
        }
    }
}
