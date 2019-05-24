using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            StatisticsDisplay sd = new StatisticsDisplay(wd);
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(wd);
            wd.setMeasurements(80, 65, 30.4f);
            wd.setMeasurements(82, 70, 29.2f);
            wd.setMeasurements(78, 90, 29.2f);
            wd.removeObserver(sd);
            Console.WriteLine("Delete one observer");
            wd.setMeasurements(75, 92, 28.7f);
            Console.ReadKey();
        }
    }
}
