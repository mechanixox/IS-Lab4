using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barte_SearchAlgo
{
    public class Util
    {
        public static double distance(Vertex A, Vertex B)
        {
            int x1 = A.Location.X;
            int y1 = A.Location.Y;
            int x2 = B.Location.X;
            int y2 = B.Location.Y;

            //distance between two points
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

    }

}