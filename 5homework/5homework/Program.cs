using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5homework
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i <= 0; i++) ;
            Console.WriteLine();//

            //2 domashka
            Console.WriteLine("Write price of foods");
            int price = int.Parse(Console.ReadLine());
            for (int i=1; i<=10; i++)
                int price= i*price;
            Console.WriteLine(price )// nopurra
        }
    }
}
