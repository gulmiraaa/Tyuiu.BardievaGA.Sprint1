using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Title = " Спринт #1 |Выполнила: Бардиева Г. А.| ИСПб-23-1 ";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Работа со строками класс String                                    *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #15                                                              *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine("*Проверить, что в строке больше букв, чем знаков.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckLettersCount(value));
            Console.ReadLine();
        }
    }
}
