using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trriandle
{
    class triangle
    {
        public double a;
        public double b;
        public double c;

        public triangle(int A, int B, int C) 
        {
            a = A;
            b = B;
            c = C;
        }
        public string outPutA()
        {
            return Convert.ToString(a);
        }
        public string outPutB()
        {
            return Convert.ToString(b);
        }
        public string outPutC()
        {
            return Convert.ToString(c);
        }
        public double Peremeter() 
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface() 
        {
            double p = 0;
            double s = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double GetSetA()
        {
            get
            { return a; }
            set
            { a = Value; }
        }
        public double GetSetB()
        {
            get
            { return b; }
            set
            { b = Value; }
        }
        public double GetSetC()
        {
            get
            { return c; }
            set
            { c = Value; }
        }
        public bool ExistTriangle()
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                return false;

                else  return true; 
            }
        }
    }
}
