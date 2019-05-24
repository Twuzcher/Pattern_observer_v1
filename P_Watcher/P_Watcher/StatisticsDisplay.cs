using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Watcher
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private float lastTemperature;
        private float avgTemperature;
        private float maxTemperature;
        private float minTemperature;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            if (lastTemperature == 0)
            {
                lastTemperature = temperature;
            }
            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }
            if (minTemperature == 0)
            {
                minTemperature = temperature;
            }
            else if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }
            if (avgTemperature == 0)
            {
                avgTemperature = temperature;
            }
            else
            {
                avgTemperature = temperature + lastTemperature;
                avgTemperature /= 2;
                lastTemperature = temperature;
            }
            display();
        }

        public void display()
        {
            Console.WriteLine("AVG/MAX/MIN: " + avgTemperature + "/" + maxTemperature + "/" + minTemperature);
        }
    }
}
