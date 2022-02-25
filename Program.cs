using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            Console.WriteLine("Введите пожалуйста любое предложение:");
            string s = Console.ReadLine();

            //PrintingWords(SplittingStringIntoWords(s));

            //Задание №2
            PrintingWords(ReverseWordsInSentence(SplittingStringIntoWords(s)));



            Console.ReadKey();
            
        }

        /// <summary>
        /// Удаляет из строки все знаки препинания и знаки-разделители
        /// </summary>
        /// <param name="str">Строка, из которой необходимо убрать знаки препинанияи и знаки-разделители</param>
        /// <returns>Возвращает массив слов из исходной строки</returns>
        public static string[] SplittingStringIntoWords(string str)
        {
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\u0022', '—' },StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        
        /// <summary>
        /// Выводит с новой строки слова из строкового массива
        /// </summary>
        /// <param name="words">Исходный массив слов</param>
        public static void PrintingWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"№{i + 1} - {words[i]}");
            }
        }

        /// <summary>
        /// Изменяет порядок слов в предложении на противоположный
        /// </summary>
        /// <param name="words">Исходный массив слов</param>
        /// <returns> Массив с противоположным порядком слов </returns>
        public static string[] ReverseWordsInSentence(string[] words)
        {
            for(int i = 0, j = words.Length - 1; i < j; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            return words;
        }


    }
}
