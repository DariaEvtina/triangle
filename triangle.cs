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

        public triangle(double A, double B, double C) 
        {
            a = A;
            b = B;
            c = C;
        }
        public triangle( double H, double A)
        {
            h = H;
            a = A;
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
        public double Half_perimeter()
        {
            double pm = Peremeter();
            double halfp = pm / 2;
            return halfp;
        }
        public double triangleheight() 
        {
            double s = Surface();
            double h = 0;
            h = (2 * s) / a;
            return h;

        }
        public double Surface() 
        {
            double p = Half_perimeter();
            double s = 0;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double SurfaceAH()
        {
            double s = 0;
            s = ((1/2)*a)*h;
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
        public double GetSetH
        {
            get { return h; }
            set { h = value; }
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
        public string Triangletype
        {
            get
            {
                if ((b == c) && (a == b) && (c == a))
                    return "kolmnurk on võrdkülgne";

                else if ((b == c) || (c == a) || (b == a))
                    return "kolmnurk on võrdhaarne";
                else return "kolmnurk on mitmekülgne";
            }
        }
    }
}
