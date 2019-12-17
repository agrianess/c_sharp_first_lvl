using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les6._1
{
  //  Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
  // Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
  // Лукашенко Валентина

 
        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
        public delegate double Fun(double x, double a);

        class Program
        {
            // Создаем метод, который принимает делегат
            // На практике этот метод сможет принимать любой метод
            // с такой же сигнатурой, как у делегата
            public static void Table(Fun F, double x, double b, double a)
            {
           

                Console.WriteLine("----- X ----- Y -----");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                    x += 1;
                }
                Console.WriteLine("---------------------");
            }
        /// <summary>
        /// a* x^2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFuncAX2(double x, double a)
            {
                return a*x * x;
            }

        /// <summary>
        /// a* sin(x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFuncASin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main()
            {
            
                Console.WriteLine("Введите коэффициент a: ");
                double a = double.Parse(Console.ReadLine());

            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a* x^2:");
            Table(MyFuncAX2, -2, 2,a);
            Console.WriteLine("Таблица функции a* sin(x)");
            Table(MyFuncASin, -2, 2, a);

            Console.ReadLine();
            }
        

    }
}
