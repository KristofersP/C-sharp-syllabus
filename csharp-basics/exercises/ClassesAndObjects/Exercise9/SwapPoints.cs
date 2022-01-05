using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class SwapPoints
    {
        public int x;
        public int y;

        public SwapPoints(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void swapPoints(SwapPoints firstPoint, SwapPoints secondPoint)
        {
            int x1 = firstPoint.x;
            int y1 = firstPoint.y;

            int x2 = secondPoint.x;
            int y2 = secondPoint.y;

            firstPoint.x = x2;
            firstPoint.y = y2;

            secondPoint.x = x1;
            secondPoint.y = y1;
        }
    }
}
