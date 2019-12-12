using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_5_1
{
    //Создать программу, которая будет проверять корректность ввода логина.
    //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского 
    //алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.
    //    Лукашенко Валентина


    class Program
    {
      
        static void Main(string[] args)
        {
            string log;
            string[] masMessage = new string[4];
            masMessage[0] = "Неверная длина логина!";
            masMessage[1] = "Логин может содержать только латинские буквы и цифры!";
            masMessage[2] = "Логин не может начинаться с цифры!";
            masMessage[3] = "Корректный логин!";

            bool br = true;

            do
            {
                Console.WriteLine("Введите логин: ");
                log = Console.ReadLine();


                if (log.Length < 2 || log.Length > 10)
                {
                    br = false;
                    Console.WriteLine(masMessage[0]);
                }

                for (int i = 0; i < log.Length - 1; i++)
                {
                    if (!(char.IsDigit(log[i])|| log[i]>='a'&&log[i]<='z' || log[i] >= 'A' && log[i] <= 'Z'))
                    {
                        br = false;
                        Console.WriteLine(masMessage[1]);
                        break;
                    }

                } 

                if (char.IsDigit(log[0]))
                {
                    br = false;
                    Console.WriteLine(masMessage[2]);
                }

                Console.WriteLine();
            }
            while (!br);

            Console.WriteLine(masMessage[3]);
            Console.ReadKey();
        }
    }
}
