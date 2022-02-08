using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_set_1
{
    internal class Question5
    {
       public void inside(double x, double y, double x1, double y1, double x2,
                          double y2)
            {
            if (x > x1 && x < x2 &&
                y > y1 && y < y2)
            { Console.WriteLine("True"); }

            else
            {
Console.WriteLine("False");
            }

            }
        
    }
}

