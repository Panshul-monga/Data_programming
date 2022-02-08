using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_set_1
{
    class Question1
    {
        public void data_type()
        {
            List<int> L1 = new List<int>();
            L1.Add(5);
            L1.Add(2);
            L1.Add(1);

            float pi = (float)Math.PI;

            object[] Data_objects = { 5, 5.0, 5 > 1, '5', 5 * 2, '5' * 2, '5' + '2', 5 / 2, 5 % 2, L1, 5 == 3, pi };

            foreach (var objects in Data_objects)
            {
                Console.WriteLine("Data type of {0} is {1}.", objects, objects.GetType());
            }
        }

    }
}
