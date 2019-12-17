using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLvl
{
    class Program
    {
        //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  
        //от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать программу, 
        //позволяющую найти и вывести количество пар элементов массива, в которых только одно число 
        //делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
        //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
        //Лукашенко Валентина
        static string SearchNumber(int [] array)
        {
          
           int count = 0;
            for (int i = 0; i < 20; i=i+2)
            {
                if (array[i] % 3 == 0 || array[i+1]%3==0)
                {
                 
                    count++;
                }
            }

            return count.ToString();
        }
        static void Main(string[] args)
        {

            int[] array = new int[20];

            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(-10000, 10000);
            }

            Console.WriteLine("Имеется массив чисел:");

            for (int i = 0; i < 20; i++)
            {
                 Console.WriteLine(array[i].ToString());
            }

            Console.WriteLine("Количество пар чисел, где хотя бы одно число делится на 3: "+ SearchNumber(array));
            Console.ReadKey();
        }
    }
}
