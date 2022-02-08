

using System;
namespace Problem_set_1
{
     class Program
{ 
    static void Main(string[] args)
    {
            Console.WriteLine("Solution1");
        Question1 Task1 = new Question1();
        Task1.data_type();

            Console.WriteLine('\n');
            
            Console.WriteLine("Solution 2");
            Question2 question2 = new Question2();
            question2.data_len();

            Console.WriteLine('\n');

            Console.WriteLine("Solution3");
            question3 Task3 = new question3();
            Task3.Trianglearea(2,2,2);

            Console.WriteLine('\n');

            Console.WriteLine("Solution4");
            question4 Task4 = new question4();
            Task4.lists();

            Console.WriteLine('\n');

            Console.WriteLine("Solution5a1");
            Question5 Task5 = new Question5();
            Task5.inside(1, 1, 0, 0, 2, 3);

            Console.WriteLine('\n');

            Console.WriteLine("Solution5a1");
            
            Task5.inside(-1, -1, 0, 0, 2, 3);


            Console.WriteLine('\n');
            
            Console.WriteLine("Solution5b");
            Task5.inside(1, 1, 0.3, 0.5, 1.1, 1.7);
            Task5.inside(1, 1, 0.5, 0.2, 1.1, 2);
           
        }
}
}


