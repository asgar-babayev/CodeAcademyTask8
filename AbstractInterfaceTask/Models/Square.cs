using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceTask.Models
{
    class Square : Figure
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }

        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}
