using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Console.WriteLine(t1);
            Triangle t2 = new Triangle(3, 4, 5);
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

            Console.ReadKey();
        }
    }
}
