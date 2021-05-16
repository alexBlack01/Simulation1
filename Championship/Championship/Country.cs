using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Championship
{
    class Country
    {
        public string Name;
        public string Path;
        public int Lambda;

        public Country(string name, string path, int lambda)
        {
            this.Path = path;
            this.Name = name;
            this.Lambda = lambda;
        }
    }
}
