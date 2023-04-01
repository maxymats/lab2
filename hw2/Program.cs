using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюєм 5трикутників
            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(3, 4, 5));
            triangles.Add(new Triangle(5, 12, 13));
            triangles.Add(new RightTriangle(5));
            triangles.Add(new RightTriangle(7));
            triangles.Add(new Triangle(8, 10, 12));
            //Виводим їх
            Console.WriteLine("Collection of all triangles:");

            foreach (Triangle t in triangles)
            { 
                Console.WriteLine($"\n{t}");
            }
            Console.WriteLine("------------------------------------------------");
            //знаходим трикутник з максимальною площею
            Triangle maxAreaTriangle = triangles[0];

            foreach (Triangle t in triangles)
            {
                if (t.Area > maxAreaTriangle.Area)
                {
                    maxAreaTriangle = t;
                }
            }
            Console.WriteLine($"Triangle with maximum area is:");
            Console.WriteLine(maxAreaTriangle);
            Console.WriteLine(maxAreaTriangle.Area);
            //взнаємо чи є трикутник правильним / неправильним
            if (maxAreaTriangle is RightTriangle)
            {
                Console.WriteLine("This triangle is right.");
            }
            else
            {
                Console.WriteLine("This triangle is not right.\n------------------------------------------------");
            }
            // використовуємо арифметичні оператори
            Console.WriteLine("Triangles for using arithmetic operators");
            Triangle t1 = new Triangle(3, 4, 5);
            Console.WriteLine($"\n{t1}");

            RightTriangle t2 = new RightTriangle(8);
            Console.WriteLine($"\n{t2}");

            Triangle t3 = t1 / 2;
            Console.WriteLine($"\n{t3}\n------------------------------------------------");

            Console.WriteLine("Using arithmetic operators\n");

            Console.WriteLine($"t1 == t2: {t1 == t2}");
            Console.WriteLine($"t1 == t3: {t1 == t3}");
            Console.WriteLine($"t1 != t2: {t1 != t2}");
            Console.WriteLine($"t1 != t3: {t1 != t3}\n------------------------------------------------");

            // масштабуєм колекцію трикутників на множник
            Console.WriteLine("Multiplied Triangle list");
            foreach (Triangle t in triangles)
            {
                Triangle multipliedTriangle = t * 2;
                Console.WriteLine($"\n{multipliedTriangle}");
            }
            Console.WriteLine("------------------------------------------------");
            //колекція радіусів описаніх кіл правильних трикутників 
            Console.WriteLine("Collection of radius of circumscribed circles of Right triangles");

            List<RightTriangle> RTriangles = new List<RightTriangle>();
            RTriangles.Add(new RightTriangle(5));
            RTriangles.Add(new RightTriangle(7));
            RTriangles.Add(new RightTriangle(9));
            RTriangles.Add(new RightTriangle(11));
            RTriangles.Add(new RightTriangle(13));

            List<double> circumscribedCircleRadii = new List<double>();
            foreach (RightTriangle triangle in RTriangles)
            {
                double radius = triangle.RadiusOfCircumscribedCircle();
                circumscribedCircleRadii.Add(radius);
                Console.WriteLine($"\nCircumscribed circle radius:  {radius}");
            }
            Console.WriteLine("------------------------------------------------");

            // Використання IComparable для порівняння трикутників за площею
            if (t1.CompareTo(t2) > 0)
                Console.WriteLine($"\nTriangle 1 with area {t1.Area:F2} is larger than Triangle 2 with area {t2.Area:F2}");
            else if (t1.CompareTo(t2) < 0)
                Console.WriteLine($"\nTriangle 1 with area {t1.Area:F2} is smaller than Triangle 2 with area {t2.Area:F2}");
            else
                Console.WriteLine($"\nTriangle 1 with area {t1.Area:F2} is equal to Triangle 2 with area {t2.Area:F2}");


            if (t3.CompareTo(t2) > 0)
                Console.WriteLine($"Triangle 3 with area {t3.Area:F2} is larger than Triangle 2 with area {t2.Area:F2}");
            else if (t3.CompareTo(t2) < 0)
                Console.WriteLine($"Triangle 3 with area {t3.Area:F2} is smaller than Triangle 2 with area {t2.Area:F2}");
            else
                Console.WriteLine($"Triangle 3 with area {t3.Area:F2} is equal to Triangle 2 with area {t2.Area:F2}");

            Console.WriteLine("------------------------------------------------");

            Triangle myTriangle = new Triangle(3, 4, 5);

            Console.WriteLine(myTriangle.ToString());
            Console.WriteLine(myTriangle.ToString("P", CultureInfo.InvariantCulture)); 
            Console.WriteLine(myTriangle.ToString("A", CultureInfo.InvariantCulture)); 
            Console.WriteLine(myTriangle.ToString("R", CultureInfo.InvariantCulture));
        }

    }
} 
