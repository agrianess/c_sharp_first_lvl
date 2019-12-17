using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace first_lvl_4_3
{
    class CoolArray 
    {
        private int[] a;
        private int maxCount;
        Random rnd = new Random();

        public CoolArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 101);
        }

        public CoolArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл 
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }
        /// <summary>
        /// Конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом       
        /// </summary>
        /// <param name="n">Размерность массива</param>
        /// <param name="step">Шаг</param>
        /// <param name="start">Начальное значение</param>
        public CoolArray(int n, int step, int start)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = start + step * i;
            }
        }


        public int Max
        {
            get
            {
                return a.Max();
            }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }

        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        /// <returns>Сумма</returns>
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                sum = sum + a[i];
            }

            return sum;
        }
/// <summary>
/// Инверсия массива
/// </summary>
/// <returns>новый массив с противоположными знаками</returns>
        public int[] Inverse()
        {
            int[] inverseMas =new int[a.Length];

            for (int i = 0; i < a.Length-1; i++)
            {
                inverseMas[i] = 0 - a[i];
            }

            return inverseMas;
        }

        /// <summary>
        /// Умножение каждого элемента массива на число
        /// </summary>
        /// <param name="mult"></param>
        public void Multi(int mult)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                a[i] = a[i] * mult;
            }
        }


        /// <summary>
        /// Возвращает количество максимальных элементов
        /// </summary>
        public int MaxCount
        {
          
            get
            {
                int maxEl = a.Max();

                for (int i = 0; i < a.Length-1; i++)
                {
                    if (a[i]==maxEl)
                    {
                        maxCount = maxCount + 1;
                    }
                }

                return maxCount;
            }

          
        }
    }
   
    }


