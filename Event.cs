using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp1
{
    class Human
    {
        public string Name { get; }

        public Human(string name)
        {
            Name = name;
        }

        public void AskForArea(Triangle Triangle)
        {
            Console.WriteLine($"Human {Name} wants to know the area of triangle with sides {Triangle.Side1} cm, {Triangle.Side2} cm, {Triangle.Side3} cm.\n");
            Triangle.AreaRequested += OnAreaRequested;
        }

        private void OnAreaRequested(object sender, EventArgs e)
        {
            Triangle Triangle = sender as Triangle;
            Console.WriteLine($" --- The area of triangle with sides {Triangle.Side1} cm, {Triangle.Side2} cm, {Triangle.Side3} cm is S = {Triangle.Area} cm^2");
            Triangle.AreaRequested -= OnAreaRequested;
        }
    }
}

