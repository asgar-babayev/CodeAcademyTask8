using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceTask.Models
{
    class Rectangular : Figure
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int CalcArea()
        {
            return Width * Length;
        }
    }
}
