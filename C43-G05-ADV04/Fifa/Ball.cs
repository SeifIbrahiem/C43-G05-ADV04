using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV04.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location 
        {
            get { return Location; }

            set {   Location = value; }
        }

        public override string ToString()
        {
            return $"Id:{Id}, Location:{Location}";
        }
    }
}
