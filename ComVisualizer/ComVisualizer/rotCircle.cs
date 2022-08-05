using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComVisualizer
{
    internal class rotCircle
    {
        public int D { get; set; }
        public const int X = 0;
        public const int Y = 0;

        
        public double L_rot { get; set; }

        public float[] calculatePoints()
        {
            float[] points = new float[4];
            //center point
            points[0] = 0;
            points[1] = 0;

            /*
             * 0.0deg = 0 radians
             * 0.0deg = {0,0,d/2,0}
             */
            double h, w;
            w = D/2.0*Math.Cos(L_rot);
            h = D/2.0*Math.Sin(L_rot);


            points[2] = (float)w;
            points[3] = (float)h;

            
            

            return points;
        }
    }
}
