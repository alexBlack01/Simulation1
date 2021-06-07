using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSimulator
{
    class Weather
    {
        public int Id;
        public string Name;
        public string Path;

        public Weather(string name, string path, int id)
        {
            this.Path = path;
            this.Name = name;
            this.Id = id;
        }
    }
}
