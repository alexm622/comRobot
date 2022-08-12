using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComVisualizer
{
    internal class MovementCurve
    {
        private Func<double, double, double, int> equation;
        public MovementCurve(Func<double, double, double, int> eq) //start, end, frame
        {
            this.equation = eq;
        }

        public double calculate(double start, double end, int frame)
        {
            double ret = 0.0;
            
            double y = equation(start, end, frame);
            return y;
        }
    }
}
