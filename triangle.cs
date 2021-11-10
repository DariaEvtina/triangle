using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Google.Protobuf.WellKnownTypes;
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
        public double h;

        public triangle(int A, int B, int C) 
        {
            a = A;
            b = B;
            c = C;
        }
        public triangle(int A, int B, int C, int H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
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
        public string outPutH()
        {
            return Convert.ToString(h);
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
        public double GetSetA
        {
            get{ return a; }
            set{ a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get{ return c; }
            set{ c = value; }
        }
        public bool ExistTriangle
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
