using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp1
{
    class Triangle : IComparable<Triangle>
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }

        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        public double Perimeter
        {
            get { return side1 + side2 + side3; }
        }

        public double Area
        {
            get
            {
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }
        }
        public override string ToString()
        {
            return $"Triangle with sides: {side1}, {side2}, {side3}";
        }
        public int CompareTo(Triangle other)
        {
            if (other == null)
                return 1;

            return this.Area.CompareTo(other.Area);
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            if (ReferenceEquals(t1, t2))
                return true;

            if (t1 is null || t2 is null)
                return false;

            return t1.Area == t2.Area;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return !(t1 == t2);
        }

        public static Triangle operator /(Triangle t, double multiplier)
        {
            Triangle result = new Triangle(t.side1/multiplier, t.side2/multiplier, t.side3/multiplier);
            return result;
        }
        public static Triangle operator *(Triangle t, double multiplier)
        {
            Triangle result = new Triangle(t.side1 * multiplier, t.side2 * multiplier, t.side3 * multiplier);
            return result;
        }
    }

    class RightTriangle : Triangle
    {
        public RightTriangle(double side1) : base(side1, side1, side1)
        {
        }

        public double Side()
        {
            return Side1;
        }

        public double RadiusOfInscribedCircle()
        {
            return Side1 / (2 * Math.Sqrt(3));
        }

        public double RadiusOfCircumscribedCircle()
        {
            return Side1 / Math.Sqrt(3);
        }

        public override string ToString()
        {
            return $"Right Triangle with side: {Side1} ,{Side1} ,{Side1}"; 
        }
    }

}
