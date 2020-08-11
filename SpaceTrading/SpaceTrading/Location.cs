using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrading
{
    class Location
    {
        public string name;
        public string description;

        double xpos;
        double ypos;
        public Location(string name, string description, double xpos, double ypos)
        {
            this.name = name;
            this.description = description;
            this.xpos = xpos;
            this.ypos = ypos;
        }
        public double DistanceTo(Location destination)
        {
            var left = Math.Pow(this.xpos - destination.xpos, 2);
            var right = Math.Pow(this.ypos - destination.ypos, 2);

            return Math.Sqrt(left + right);
        }
    }
}
