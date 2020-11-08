using System;

namespace First_Square_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим строки.
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string sndStr = Console.ReadLine();
            // Переменные
            int left = 0; // количество левых скобок.
            int right = 0; // количество правых скобок.
            bool found = false; // флаг для цикла, чтобы выйти, когда первые закрытые скобки будут найдены.
            string newStr = ""; // новая строка, чтобы записывать копию с подстрокой сюда.
            int i = 0; // переменная для указателя.

            while (found == false)
            {
                // Ищем скобки.
                if (str[i] == '[')
                    left++;
                if (str[i] == ']')
                    right++;
                // Если не находим скобки - просто прибавляем один символ в строку.
                if (left == 0)
                    newStr += str[i];
                
                //Если левые скобки не найдены и правая.
                if (left != 0 && left == right)
                {
                    newStr += sndStr;
                    found = true;
                }
                    
                i++;
            }

            // Заполняем то, что осталось.
            while (i < str.Length)
            {
                newStr += str[i];
                i++;
            }


            Console.WriteLine();
            Console.WriteLine(newStr);
            Console.ReadKey();

        }
    }
}
