using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceTask.Models
{
    class Square : Figure
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }
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
