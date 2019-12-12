using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_5_2
{
//    Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается 
//        массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива
//        входит в этот текст.Здесь требуется использовать класс Dictionary.
//        Лукашенко Валентина
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст сообщения");
            string mes = Console.ReadLine();
   //пункт а)
            Console.WriteLine();
            Console.WriteLine("Введите ограничение по количеству букв в слове");
            int countSym = Int32.Parse(Console.ReadLine());
            Message.PrintMessage(mes, countSym);
    //пункт б)
            Console.WriteLine();
            Console.WriteLine("Введите символ, слова заканчивающиеся на который, следует удалить");
            char sym = char.Parse(Console.ReadLine());
            Message.DeleteWord(mes, sym);

    //пункт в)
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово/слова в сообщении");
            string[] masWords = Message.MaxLenghtWord(mes);

            for (int i = 0; i < masWords.Length; i++)
            {
                Console.WriteLine(masWords[i]);
            }
     //пункт г)
            Console.WriteLine();
            Console.WriteLine("Строка из самых длин слов в сообщении");
            Console.WriteLine( Message.StrMaxLenghtWords(mes));

      //пункт д)
            Console.WriteLine("Введите массив слов через пробел:");
            string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Message.CountEntrys(str,mes);


            Console.ReadKey();
        }
    }
}
