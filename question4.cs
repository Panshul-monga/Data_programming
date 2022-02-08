using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_set_1
{
    internal class question4
    {
        public void lists()
        {
            List<int> Original_List = new List<int>();

            Original_List.Add(25);
            Original_List.Add(47);
            Original_List.Add(42);
            Original_List.Add(56);
            Original_List.Add(32);

            Console.WriteLine(Original_List);

            List<int> List_of_Odds = new List<int>();
            List<int> List_of_Evens = new List<int>();

            foreach (int element in Original_List)
            {
                if (element % 2 == 0)
                {
                    List_of_Evens.Add(element);
                }
                else if (element % 2 == 1)
                {
                    List_of_Odds.Add(element);
                }
            }

            Console.WriteLine("List of evens is {0},{1},{2}", List_of_Evens[0], List_of_Evens[1], List_of_Evens[2]);
            Console.WriteLine("List of odds is {0},{1}", List_of_Odds[0], List_of_Odds[1]);

        }
    }
}
