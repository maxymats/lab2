using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Triangle : IComparable<Triangle>
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

        public Triangle(Triangle other)
        {
            this.side1 = other.side1;
            this.side2 = other.side2;
            this.side3 = other.side3;
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

        public static Triangle operator /(Triangle t, double factor)
        {
            Triangle result = new Triangle(t.side1, t.side2, t.side3);
            return result;
        }
    }
}
