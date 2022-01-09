using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        public int quantity;

        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
