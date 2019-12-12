using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_5_2
{
    struct WordCount
    {
        public string word;
        public int count;

        public WordCount(string word, int count)
        {
            this.count = count;
            this.word = word;

        }
    }
   static class Message
    { 
      static  private string DeletePunctuation(string mes)
    {
            string[] punctuation_marks = { ".", ",", "!", "?", ";", ":", "-" };
            for (int i = 0; i < mes.Length; i++)
            {
                for (int j = 0; j < punctuation_marks.Length; j++)
                {
                    if (mes[i].ToString() == punctuation_marks[j])
                    {
                        mes = mes.Remove(i, 1);
                        break;
                    }
                }
            }

            return mes;
    }


    /// <summary>
     /// Вывести только те слова сообщения,  которые содержат не более n букв.
     /// </summary>
     /// <param name="mes"></param>
     /// <param name="limit"></param>
    public static void PrintMessage(string mes, int limit)
        {
            string tmp="";
            mes = DeletePunctuation(mes);
            string[] parts = mes.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length<=limit)
                {
                    if (tmp != "") tmp = tmp + " " + parts[i];
                    else tmp = parts[i];
                }
            }

            Console.WriteLine(tmp);

        }


        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="sym"></param>
        /// <returns></returns>
        
        public static void DeleteWord(string mes, char sym)
        {
            mes = DeletePunctuation(mes);
            string tmp = "";

            string[] parts = mes.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].LastIndexOf(sym)!=parts[i].Length-1)
                {
                    if (tmp != "") tmp = tmp + " " + parts[i];
                    else tmp = parts[i];
                }
            }

            Console.WriteLine(tmp);

        }


        /// <summary>
        /// Найти самое длинное слово сообщения.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string[] MaxLenghtWord(string mes)
        {
            string [] tmp;
            int maxLenght = 0;
            int masLenght = 0;
            mes = DeletePunctuation(mes);
            string[] parts = mes.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (maxLenght<parts[i].Length)
                {
                    maxLenght = parts[i].Length;
                }
            }

            for (int i = 0; i < parts.Length; i++)
            {
                if (maxLenght == parts[i].Length)
                {
                    masLenght++;
                }
            }

            tmp = new string[masLenght];
            int indexMas = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length==maxLenght)
                {
                    tmp[indexMas] = parts[i];
                    indexMas++;
                }
            }


            return tmp;
        }


        /// <summary>
        /// Сформировать строку с помощью StringBuilder из самых длинных слов сообщения
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string StrMaxLenghtWords(string mes)
        {
            string[] tmp = MaxLenghtWord(mes);

            StringBuilder strBuild = new StringBuilder();

            for (int i = 0; i < tmp.Length; i++)
            {
                strBuild.Append(tmp[i]+" ");
            }

            return strBuild.ToString();
        }


        /// <summary>
        ///  частотный анализ текста
        /// </summary>
        /// <param name="masWords"></param>
        /// <param name="nameFile"></param>
        /// <returns></returns>
        public static void CountEntrys(string[] masWords, string text)
        {
            List<WordCount> list = new List<WordCount>();

            int count = 0;
            text = DeletePunctuation(text);
            string[] masText = text.Split(' ');

            // поиск совпадений

            for (int i = 0; i < masWords.Length; i++)
            {
                for (int j = 0; j < masText.Length; j++)
                {
                    if (masWords[i]==masText[j])
                    {
                        count++;
                    }
                }

                list.Add(new WordCount(masWords[i],count));
                count = 0;
                

            }
            foreach (WordCount item in list)
            {
                Console.WriteLine(item.word,item.count.ToString());
            }

          
        }
    }
}
