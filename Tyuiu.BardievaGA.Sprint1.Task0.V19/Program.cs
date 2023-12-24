using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.Task0.V19.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражеие 4/2*5/(3+2)*5 и печатает результат на экране.

namespace Tyuiu.BardievaGA.Sprint1.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = " Спринт #1 |Выполнила: Бардиева Г. А.| ИСПб-23-1 ";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("*Задание #0                                                               *");
            Console.WriteLine("*Вариант #19                                                              *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая вычисляет выражение 4 / 2 * 5 / (3 + 2) * 5  *");
            Console.WriteLine("*и печатает результат на экране.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 4 / 2 * 5 / (3 + 2) * 5                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.BardievaGA.Sprint1.Task0.V19.Lib
            //в классе DataServise
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
