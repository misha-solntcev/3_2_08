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
        static string[] StringToWords(string myString)
        {
            char[] sep = { ' ', '.'};
            string[] myWords = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            return myWords;
        }
        static string IfPalindrom(string[] myWords)
        {
            string newString = "";
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
                    newString += myWords[i] + " ";
            }
            return newString;            
        }
        static void Main(string[] args)
        {
            string myString = "ABCBA маfggfам vfvffdas маам";
            string newString = IfPalindrom(StringToWords(myString));
            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
