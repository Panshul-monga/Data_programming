using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_set_1
{
    internal class question3
    {
        public void Trianglearea(int a, int b, int c)
        {

            int s = (a + b + c) / 2;
            double solution = (double)Math.Sqrt(s*(s-a) * (s-b) * (s-c));
            Console.WriteLine("Area of Triangle with sides {0}, {1}, {2}, {3}.",a, b, c, solution);
        }
    }
}
