using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_set_1
{
    class Question2
    {
        public void data_len()
        {
            string str_len = "Supercalifragilisticexpialidocious";
            int result1 = str_len.Length;
            Console.WriteLine("The length of the given string is {0}.", result1);
            
            string s2 = "ice";
             bool b1 = str_len.Contains(s2);
            if (b1==true)
            {
                Console.WriteLine("The given string contains ice.");
            }
            else
            {
                Console.WriteLine("The given string does not contain ice");
            }

            string p1 = "Supercalifragilisticexpialidocious";
            string p2 = "Honorificabilitudinitatibus";
            string p3 = "Bababadalgharaghtakamminarronnkonn";

            int num1 = p1.Length;
            int num2 = p2.Length;
            int num3 = p3.Length;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");


            
            string[] words = new string[]
            {"Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein"};
            Array.Sort(words);

            Console.WriteLine("The first word will be {0} and the last word will be {1}.", words[0], words[words.Length-1]);

        }

    }


    }
