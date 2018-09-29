using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StructureComplex
{
    struct Complex
    {
        public double im;
        public double re;
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Subtraction(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 2;
            Complex complex2;
            complex2.re = 1;
            complex2.im = 2;
            Complex complex3;
            complex3.re = 1;
            complex3.im = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Сложение: ");
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Умножение: ");
            Console.WriteLine(result.ToString());
            result = complex3.Subtraction(complex3);
            Console.WriteLine("Вычитание: ");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}