using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrading
{
    class Planets
    {
        string[] planetName = new string[5];
        public static int currentPlanet;

        public Planets() { }

        public static string getPlanetName(int currentPlanet)

        {

            if (currentPlanet == 1)

            {

                return new Planets().planetName[0] = "Earth";

            }

            else if (currentPlanet == 2)

            {

                return new Planets().planetName[1] = "Tarantulon6";

            }

            else if (currentPlanet == 3)

            {

                return new Planets().planetName[2] = "Amazonia";

            }

            else if (currentPlanet == 4)

            {

                return new Planets().planetName[3] = "Tornadus";

            }

            else if (currentPlanet == 5)

            {

                return new Planets().planetName[4] = "Decapod10";

            }

            else if (currentPlanet == 6)

            {

                return new Planets().planetName[5] = "Thuban9";

            }
            return getPlanetName(currentPlanet);

        }
    }
}
