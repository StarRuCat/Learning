using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fractions
{
    class Program
    {
        public double x1 = 0; //Первый числитель
        public double x2 = 0; //Второй числитель
        public double y1 = 0; //Первый знаменатель
        public double y2 = 0; //Второй знаменатель

        static void Main()
        {
            WriteLine("Введите числитель первой дроби: ");
            Program x1 = double.Parse(ReadLine());
            WriteLine("Введите знаменатель первой дроби: ");
            WriteLine("Введите числитель второй дроби: ");
            WriteLine("Введите знаменатель второй дроби: ");
        }
        static void Adition()
        {

        }
    }
}
