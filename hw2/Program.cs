using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(3, 4, 5));
            triangles.Add(new Triangle(5, 12, 13));
            triangles.Add(new RightTriangle(5));
            triangles.Add(new RightTriangle(7));
            triangles.Add(new Triangle(8, 10, 12));

            Console.WriteLine("All triangles:");

            foreach (Triangle t in triangles)
            {
                Console.WriteLine(t);
            }

            Triangle maxAreaTriangle = triangles[0];

            foreach (Triangle t in triangles)
            {
                if (t.Area > maxAreaTriangle.Area)
                {
                    maxAreaTriangle = t;
                }
            }
            Console.WriteLine($"Triangle with maximum area:");

            Console.WriteLine(maxAreaTriangle.Area);

            Console.WriteLine(maxAreaTriangle);

            if (maxAreaTriangle is RightTriangle)
            {
                Console.WriteLine("This triangle is right.");
            }
            else
            {
                Console.WriteLine("This triangle is not right.");
            }
 
           

            Triangle t1 = new Triangle(3, 4, 5);
            Console.WriteLine(t1);

            Triangle t2 = new Triangle(4, 6, 8);
            Console.WriteLine(t2);

            Triangle t3 = t1 / 2;
            Console.WriteLine(t3);

            Console.WriteLine($"t1 area: {t1.Area}");
            Console.WriteLine($"t2 area: {t2.Area}");
            Console.WriteLine($"t3 area: {t3.Area}");

            Console.WriteLine($"t1 == t2: {t1 == t2}");
            Console.WriteLine($"t1 == t3: {t1 == t3}");
            Console.WriteLine($"t1 != t2: {t1 != t2}");
            Console.WriteLine($"t1 != t3: {t1 != t3}");
        }
    }
}
