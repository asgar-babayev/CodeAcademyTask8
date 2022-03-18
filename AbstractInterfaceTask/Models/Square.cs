using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceTask.Models
{
    class Square : Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double CalcArea()
        {
            return Math.Round(Side * Side, 3);
        }
    }
}
