using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public double AreaOfCircle(decimal radius)
        {
            return Math.Round(Math.PI * (double)radius * 2, 2);
        }

        public double AreaOfRectangle(decimal length, decimal width)
        {
            return (double)(length * width);
        }

        public double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)(ground * h * (decimal)0.5);
        }
    }
}
