﻿using System;
using System.Collections.Generic;
using System.Text;




namespace SpaceGame

{

    public static class WarpSpeed

    {

        public static double WarpSpeedToLightSpeed(double w)

        {

            if ((w <= 0) || (w > 9.5)) throw new ArgumentOutOfRangeException();



            return Math.Pow(w, 10.0 / 3) + Math.Pow(10 - w, -11.0 / 3);

        }

    }

}
