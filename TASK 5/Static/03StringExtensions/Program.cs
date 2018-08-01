using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать собственные реализации методов Substring(int,int), IndexOf(string), Replace(string,string)

namespace _03StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "To be or not to be";
            
            Console.WriteLine(sample.Substring(3,9)); //тест использования библиотечной функции
            Console.WriteLine(sample.UserSubString(3,12)); //тест использования пользовательской функции  

            Console.WriteLine(sample.IndexOf("be")); //тест библиотечной функции
            Console.WriteLine(sample.UserIndexOf("be")); //тест пользовательской функции

            string newString = sample.Replace("to", "two"); //тест библиотечной функции
            Console.WriteLine(newString);

            newString = sample.UserReplace("to", "two"); //тест пользовательской функции
            Console.WriteLine(newString);
            newString = sample.UserReplace("be", "bee"); //тест пользовательской функции (два вхождения)
            Console.WriteLine(newString);
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// Метод-расширение для класса String.
        /// Испльзует технику делегирования - вызывает метод стандартной библиотеки, но
        /// немного меняет поведение параметров
        /// </summary>
        /// <param name="str"></param>
        /// <param name="begin">стартовый индекс</param>
        /// <param name="end">конечный индекс</param>
        /// <returns>подстроку</returns>
        public static string UserSubString(this string str, int begin, int end)
        {
            return str.Substring(begin, end-begin);
        }


        /// <summary>
        /// Пользовательский метод нахождения индекса первого вхождения подстроки
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="find">подстрока, которую нужно найти</param>
        /// <returns>индекс первого вхождения или -1, если не найдено</returns>
        public static int UserIndexOf(this string str, string find)
        {
            if (find.Length > str.Length) return -1;           

            int i, j;
            int lenStr = str.Length;
            int lenFind = find.Length;
            
            for(i = 0; i <=lenStr - lenFind; i++)
            {
                for (j = 0; str[i + j] == find[j]; j++)
                {
                    if (j == lenFind-1) return i;
                }                              
            }
            return -1;
        }

        /// <summary>
        /// Пользовательский метод замены всех вхождений
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue">строка, которую заменять</param>
        /// <param name="newValue">строка, на которую заменять</param>
        /// <returns>новую строку</returns>
        public static string UserReplace(this string str, string oldValue, string newValue)
        {
            int lenStr = str.Length;
            int lenOld = oldValue.Length;
            int lenNew = newValue.Length;
            if (lenNew >= lenStr && lenOld >= lenStr) return str;

            
            int extraLength = lenNew - lenOld;

            int count = 0;
            int idx = 0;
            while (idx != -1 && idx < lenStr)
            {
                string substr = str.Substring(idx, lenStr - idx);                
                idx += substr.IndexOf(oldValue);
                if (idx != -1)
                {
                    count++;
                    idx += lenOld;
                }
            }
            int[] indexes = new int[count];
            int i = 0; // счетчик количества вхождений
            idx = 0;
            while (idx != -1 && idx < lenStr)
            {
                string substr = str.Substring(idx, lenStr - idx);
                idx += substr.IndexOf(oldValue);
                if (idx != -1)
                {
                    indexes[i] = idx;
                    i++;
                    idx += lenOld;
                }
            }

            char[] result = new char[lenStr + count * extraLength];
            int j = 0; // счетчик, который пойдет по массиву result
            int k = 0; // счетчик, который будет идти по исходной строке
            int l; // счетчик, который будет ходить по строке, на которую заменяем
            for (i = 0; i < indexes.Length; i++)
            {
                for (; k < indexes[i]; j++, k++) result[j] = str[k];
                for (l = 0; l < lenNew; l++, j++) result[j] = newValue[l];
                k += lenOld;
            }
            for (; k < lenStr; j++, k++) result[j] = str[k];
            return new string(result);
        }
    }
}
