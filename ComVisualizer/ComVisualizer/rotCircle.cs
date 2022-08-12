using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComVisualizer
{
    internal class RotCircle
    {
        public int D { get; set; }
        public const int X = 0;
        public const int Y = 0;
        public double movingTo = 0.0;
        public double movingFrom = 0.0; 
        public int frame = -1; //if frame is -1 then there is no animation
        public bool direction = true;

        
        public double currentRotation { get; set; } //current rotation

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
            w = D/2.0*Math.Cos(currentRotation);
            h = D/2.0*Math.Sin(currentRotation);


            points[2] = (float)w;
            points[3] = (float)h;

            
            

            return points;
        }

        public void rotateTo(double to)
        {
            frame = 0;
            if (to < currentRotation)
            {
                direction = false; //counterclockwise, we want to animate backwards
            }

            movingTo = to;
            movingFrom = currentRotation;
        }
    }
}
