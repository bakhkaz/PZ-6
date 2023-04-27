using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class Postavshik
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public Postavshik(string name)
        {
            _name = name;
        }
    }
}
