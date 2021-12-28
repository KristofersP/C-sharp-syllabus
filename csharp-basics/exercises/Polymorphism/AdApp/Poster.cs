using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _numberOfCopies;
        private int _costPerCopy;
        private double _size; // in cm^2

        public Poster(int fee, int numberOfCopies, int costPerCopy, double size) : base(fee)
        {
            _numberOfCopies = numberOfCopies;
            _costPerCopy = costPerCopy;
            _size = size;
        }

        public new double Cost()
        {
            return base.Cost() + _size * _numberOfCopies * _costPerCopy;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
