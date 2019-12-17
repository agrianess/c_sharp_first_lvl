using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace les_5_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            string log;
            bool br = false; 
            Regex reg = new Regex(@"[a-z]{1}[a-z0-9]{1,9}", RegexOptions.IgnoreCase);
            do
            {
                br = true;
                Console.WriteLine("Введите логин: ");
                log = Console.ReadLine();
                                
                if (!(reg.IsMatch(log)))
                {
                    Console.WriteLine("Логин не соответствует формату!");
                    br = false;
                }

            } while (!br) ;


            Console.WriteLine("Логин корректен!");
            Console.ReadKey();
        }
    }
}
