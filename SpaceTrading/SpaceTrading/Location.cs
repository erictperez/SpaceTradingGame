
using System;

using System.Collections.Generic;



namespace SpaceGame

{

    public class Location

    {
        public string name;

        public string description;

        double xPos;

        double yPos;

        public Location(string name, string description, double xPos, double yPos)

        {
            this.name = name;

            this.description = description;

            this.xPos = xPos;

            this.yPos = yPos;


        }



        public double DistanceTo(Location destination)

        {

            var left = Math.Pow(this.xPos - destination.xPos, 2);

            var right = Math.Pow(this.yPos - destination.yPos, 2);



            return Math.Sqrt(left + right);

        }

    }
}

