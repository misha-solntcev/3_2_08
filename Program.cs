using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 8
Дана строка.Словом текста считается любая последовательность букв; между
соседними словами - не менее одного пробела, за последним словом - точка. Найти и
сохранить в строке те слова, символы которых образуют симметричную
последовательность букв (палиндром). Все остальные слова удалить. Большие и малые
буквы алфавита считать эквивалентными.*/

namespace _3_2_08
{
    internal class Program
    {        
<<<<<<< HEAD
        static string[] StringToWords(ref string myString)
=======
        static string[] StringToWords(string myString)
>>>>>>> 41289bc (Финиш.)
        {
            char[] sep = { ' ', '.'};
            string[] myWords = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            return myWords;
        }
        static string IfPalindrom(string[] myWords)
        {
            string myString = "";
            for (int i = 0; i < myWords.Length; i++)
            {               
                bool flag = true;
                for (int j = 0; j < myWords[i].Length / 2; j++)
                {
                    if (myWords[i][j] != myWords[i][(myWords[i].Length) - 1 - j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                    myString += myWords[i] + " ";
            }
            return myString;            
        }
        static void Main(string[] args)
        {
            string myString = "ABCBA маfggfам vfvffdas маам";
            string newString = IfPalindrom(StringToWords(ref myString));
            Console.WriteLine(newString);            
            Console.ReadKey();
        }
    }
}
