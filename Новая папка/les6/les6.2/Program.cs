using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace les6._2
//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором
//хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 
/// Лукашенко Валентина

{
    public delegate double Fun(double x);

    class Program
    {
        #region Func
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return -x * x * x + 2;
        }

        public static double F3(double x)
        {
            return Math.Log(x)+2*x;
        }

        public static double F4(double x)
        {
            return Math.Tan(x);
        }

        public static double F5(double x)
        {
            return Math.Abs(x - 3) + 5;
        }

#endregion
        public static void SaveFunc(Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;

            List<double> listD = new List<double>();

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                listD.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();

            double[] masZnach = listD.ToArray();

            return masZnach;
        }
        static void Main(string[] args)
        {
          

            List<string> listFun = new List<string>();
            listFun.Add("x^2-50x+10");
            listFun.Add("-x^3+2");
            listFun.Add("Ln(X)+2*x^2");
            listFun.Add("Tg(x^2)");
            listFun.Add("|x-3|+5");

            Console.WriteLine("Выберите необходимую функцию:");
            Console.WriteLine();

            foreach (var l in listFun)
            {
                Console.WriteLine($"Введите {listFun.IndexOf(l)} для выбора функции: {l}");
                Console.WriteLine();
            }

            int typeFunc = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите начало отрезка значений х:");
            double xStart = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите окончание отрезка значений х:");
            double xFinish = double.Parse(Console.ReadLine());

            switch(typeFunc)
            {
                case 0:
                    SaveFunc(F1,"data.bin", xStart, xFinish, 0.5);
                    break;
                case 1:
                    SaveFunc(F2, "data.bin", xStart, xFinish, 0.5);
                    break;
                case 2:
                    SaveFunc(F3, "data.bin", xStart, xFinish, 0.5);
                    break;
                case 3:
                    SaveFunc(F4, "data.bin", xStart, xFinish, 0.5);
                    break;
                case 4:
                    SaveFunc(F5, "data.bin", xStart, xFinish, 0.5);
                    break;

            }


            Console.WriteLine($"Минимальное значение функции  {listFun.ElementAt(typeFunc)} на отрезке от {xStart} до {xFinish} равно:");
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}

