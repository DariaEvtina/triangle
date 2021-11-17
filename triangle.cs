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
        public triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public triangle(double H, double A)
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
            double p = a + b + c;
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
            double h = (2 * s) / a;
            return h;

        }
        public double Surface()
        {
            double p = Half_perimeter();
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double SurfaceAH()
        {
            double s = (a / 2) * h;
            return s;
        }
        public double findC()
        {
            double c = Math.Sqrt(Math.Pow(a,2)+Math.Pow(h,2));
            return c;
        }
        public double findB()
        {
            double b = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2));
            return b;
        }
        public double GetSetA
        {
            get { return a; }
            set { a = value; }
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
            get { return c; }
            set { c = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a > (b + c)) && (b > (a + c)) && (c > (a + b)))
                    return false;
                else if ((a < 1) || (b < 1) || (c < 1))
                    return false;
                else if((a > (findB() + findC())) && (findB() > (a + findC())) && (findC() > (a + findB())))
                    return false;
                else return true;

            }
        }
        public string Triangletype
        { 
            get
            {
                if ((b == c) && (a == b) && (c == a))
                    return "võrdkülgne";
                else if (ExistTriangle != true)
                    return "katkendlik joon";
                else if ((b == c) || (c == a) || (b == a))
                    return "võrdhaarne";
                else return "mitmekülgne";
            }
        }
        public string TriangletypeHA
        {
            get
            {
                if (a%2==0)
                    return "võrdhaarne";
                else if((findC()==a)&&(findB()==a)&&(findB()==findC()))
                    return "võrdkülgne";
                else if (ExistTriangle != true)
                    return "katkendlik joon";
                else return "mitmekülgne";
            }
        }
    }
}
