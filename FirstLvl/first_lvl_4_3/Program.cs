using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_lvl_4_3
    //Дописать класс для работы с одномерным массивом.
    //Реализовать конструктор, создающий массив определенного размера и заполняющий 
    //массив числами от начального значения с заданным шагом.Создать свойство Sum, которое 
    //возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными 
    //знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi,
    //умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество 
    //максимальных элементов.
    //Лукашенко Валентина
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolArray a = new CoolArray(10,2,-2);
            Console.WriteLine("Массив, с заданным шагом:");
            a.Print();

            Console.WriteLine("\n Инверсия:");
            int[] b = new int [10];
            b = a.Inverse();

            foreach (int el in b)
                Console.Write("{0,4}", el);

            Console.WriteLine("\n Массив, умноженный на 3:");
            a.Multi(3);
            a.Print();

            Console.WriteLine("\n Количество максимаьных элементов: "+a.MaxCount.ToString());
            Console.ReadKey();

        }
    }
}
