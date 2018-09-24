using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lession1
{
    class Program
    {
        static void Main()
        {
            WriteLine("Какую программу вы бы хотели использовать?");
            WriteLine("1.Анкета");
            WriteLine("2.Расчет ИМТ");
            WriteLine("3.Подсчет расстояния между точками");
            WriteLine("4.Обмен значений двух переменных");
            WriteLine("5.Авторство");
            string user_answer = ReadLine();
            switch (user_answer)
            {
                case "1":
                    Clear();
                    Questionnaire();
                    break;
                case "2":
                    Clear();
                    BMI();
                    break;
                case "3":
                    Clear();
                    DBP();
                    break;
                case "4":
                    Clear();
                    Replasment();
                    break;
                case "5":
                    Author();
                    break;
                default: break;
            }
        }

        static void Questionnaire() //Анкета
        {
            WriteLine("Введите свое имя: ");
            string name = ReadLine();
            WriteLine("Введите свою фамилию: ");
            string surname = ReadLine();
            WriteLine("Укажите свой возраст: ");
            string age = ReadLine();
            WriteLine("Рост в см: ");
            string growth = ReadLine();
            WriteLine("И вес в кг: ");
            string weight = ReadLine();
            WriteLine("Какое-нибудь большое число:");
            double number = double.Parse(ReadLine());

            Clear();

            WriteLine("Ваша анкета готова! " + "Имя: " + name + ", Фамилия: " + surname + ", возраст: " + age + " лет/года"  + ", рост: " + growth + "cм" + ", вес: " + weight + "кг");
            WriteLine("${0}", number.ToString("## ### ### ###.##"));
            ReadKey();
        }

        static void BMI() //Индекс массы тела
        {
            WriteLine("Укажите свой вес в килограммах: ");
            int weight = Int32.Parse(ReadLine());
            WriteLine("Укажите свой рост в метрах, через запятую: ");
            double growth = double.Parse(ReadLine());
            double I = Math.Round(weight / (growth * growth));

            WriteLine("Ваш индекс массы тела равен: " + I);
            ReadKey();
        }

        static void DBP() //Дистанция между точками
        {
            WriteLine("Укажите x1: ");
            double x1 = double.Parse(ReadLine());
            WriteLine("Укажите y1: ");
            double y1 = double.Parse(ReadLine());
            WriteLine("Укажите x2: ");
            double x2 = double.Parse(ReadLine());
            WriteLine("Укажите y2: ");
            double y2 = double.Parse(ReadLine());

            double r = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2), 2);
            WriteLine("Расстояние между точками равно: " + r);
            ReadKey();
        }

        static void Replasment()
        {
            WriteLine("Введите значение для первой перменной: ");
            int a = Int32.Parse(ReadLine());
            WriteLine("Введите значение для второй переменной: ");
            int b = Int32.Parse(ReadLine());
            WriteLine("Первая переменная равна: " + a + ". Вторая переменная равна: " + b);
            WriteLine("Меняем значения переменных...");
            a = a + b - (b = a);
            WriteLine("Теперь значение первой переменной: " + a + ". Второй переменной: " + b);
            ReadKey();
        }

        static void Author()
        {
            WriteLine("                                             " + "Федор Томилов, Москва");
            ReadKey();
        }
    }
}