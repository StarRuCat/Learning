using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lession2
{
    /// <summary>
    /// Домашнее задание второго занятия C# lvl1
    /// </summary>
    class Program
    {
        public static bool access = false;
        public static int attempts = 1;
        public static int length = 0;
        /// <summary>
        /// Если переменная access - истинна, тогда можно будет выбрать остальные программы
        /// </summary>
        static void Main()
        {
            Login();
            if (access == true)
            {
                Clear();
                WriteLine("Авторизация успешна");
                WriteLine("Выберите программу для запуска: ");
                WriteLine("1: Поиск минимального числа из трех");
                WriteLine("2: Рассчет индекса массы тела");
                WriteLine("3: Подсчет количества цифр числа");
                string user_answer = ReadLine();
                switch (user_answer)
                {
                    case "1":
                        Clear();
                        Min();
                        break;
                    case "2":
                        Clear();
                        BMI();
                        break;
                    case "3":
                        Clear();
                        NumberLength();
                        break;
                }
            }
            else
            {
                WriteLine("Доступ закрыт");
                ReadKey();
            }
        }
        /// <summary>
        /// Написать метод, возвращающий минимальное из трех чисел.
        /// </summary>
        static void Min()
        {
            WriteLine("Введите первое число: ");
            long a = long.Parse(ReadLine());
            WriteLine("Введите второе число: ");
            long b = long.Parse(ReadLine());
            WriteLine("Введите третье число: ");
            long c = long.Parse(ReadLine());
            long min = a;
            if(min > b){min = b;}
            if(min > c){min = c;}
            WriteLine("Минимальное число: " + min);
            ReadKey();
        }
        /// <summary>
        /// Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
        /// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        /// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        /// С помощью цикла do while ограничить ввод пароля тремя попытками.
        /// </summary>
        static void Login()
        {
            do
            {
                attempts++;
                WriteLine("Пожалуйста, авторизуйтесь");
                WriteLine("Введите логин: ");
                string login = ReadLine();
                WriteLine("Введите пароль: ");
                string pass = ReadLine();
                if (login == "root" && pass == "GeekBrains")
                {
                    Program.access = true;
                    break;
                }
                else
                {
                    WriteLine("Вы ошиблись, повторите ввод");
                }
            }
            while (attempts <= 3);
        }
        /// <summary>
        /// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        /// </summary>
        static void BMI()
        {
            WriteLine("Укажите свой вес в килограммах: ");
            int weight = Int32.Parse(ReadLine());
            WriteLine("Укажите свой рост в метрах, через запятую: ");
            double growth = double.Parse(ReadLine());
            double bmi = Math.Round(weight / (growth * growth), 2);

            WriteLine("Ваш индекс массы тела равен: " + bmi);
            if(bmi > 25)
            {
                WriteLine("Вам стоит похудеть на: " + Math.Round(weight - 25 * (growth * growth)) + "кг");
            }
            else if(bmi < 18.5)
            {
                WriteLine("Вам стоит набрать вес на: " + Math.Round(weight - 18.5 * (growth * growth)) + "кг");
            }
            else
            {
                WriteLine("Ваш вес в норме");
            }
            ReadKey();
        }
        /// <summary>
        /// Написать метод подсчета количества цифр числа.
        /// </summary>
        static void NumberLength()
        {
            WriteLine("Введите любое число: ");
            double number = Double.Parse(ReadLine());
            if (number < 0)
            {
                length = length - 1;
            }
            if (number != Math.Round(number))
            {
                length = length - 1;
            }
            string numberString = number.ToString();
            WriteLine("Количество цифр в числе: " + (length + numberString.Length));
            ReadKey();
        }
    }
}
