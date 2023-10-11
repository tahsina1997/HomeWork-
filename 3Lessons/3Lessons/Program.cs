using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());
            if ( n > 0) n++;
            else n -=2;
            Console.WriteLine(n);
            Console.ReadKey();




        }
    }
}
