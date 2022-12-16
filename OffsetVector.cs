using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceLab
{
    internal class OffsetVector : Vector
    {
        private double a,b;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        public OffsetVector(double x1 = 0, double y1 = 0, double x2 = 0, double y2 = 0, double a = 0, double b = 0) : base(x1,y1,x2,y2)
        {
            this.a = a;
            this.b = b;
        }

        public double GetParallogramArea()
        {
            return Math.Abs((X2-X1)*(X2-X1 + a) + (Y2 - Y1) * (Y2 - Y1 - b));
        }
        
    }
}
