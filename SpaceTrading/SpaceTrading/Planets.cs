using SpaceGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrading
{
    class Planets
    {
        string[] planetName = new string[5];
        public static int currentPlanet;
        public double[] x = new double[5];
        public double[] y = new double[5];

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
        public static double planetX()

        {

            if (currentPlanet == 1)

            {

                return new Planets().x[0] = 0;

            }

            else if (currentPlanet == 2)

            {

                return new Planets().x[1] = 2;

            }

            else if (currentPlanet == 3)

            {

                return new Planets().x[2] = -3;

            }

            else if (currentPlanet == 4)

            {

                return new Planets().x[3] = 4;

            }

            else if (currentPlanet == 5)

            {

                return new Planets().x[4] = -5;

            }

            else if (currentPlanet == 6)

            {

                return new Planets().x[5] = -6;

            }
            return planetX();

        }

        public static double planetY()

        {

            if (currentPlanet == 1)

            {

                return new Planets().y[0] = 0;

            }

            else if (currentPlanet == 2)

            {

                return new Planets().y[1] = 4;

            }

            else if (currentPlanet == 3)

            {

                return new Planets().y[2] = -6;

            }

            else if (currentPlanet == 4)

            {

                return new Planets().y[3] = 8;

            }

            else if (currentPlanet == 5)

            {

                return new Planets().y[4] = -10;

            }

            else if (currentPlanet == 6)

            {

                return new Planets().y[5] = 12;

            }
            return planetY();

        }
    }
}
