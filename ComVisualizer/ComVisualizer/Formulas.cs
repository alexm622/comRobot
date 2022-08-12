using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComVisualizer
{
    internal class Formulas
    {
        public static double RotateCurve(double start, double end, int frame)
        {
            double hmax = start - end;
            double speed = 1.0;

            double n = hmax / (speed + 1) * Math.PI;

            double period = (2*Math.PI)/(2*n);

            double frameAsLoc = -(speed * Math.Cos(period * frame)) / period + n / Math.PI;

            return frameAsLoc;
        }
    }
}
