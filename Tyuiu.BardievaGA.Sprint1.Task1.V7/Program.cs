using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.Task1.V7.Lib;
//ЗАДАНИЕ.
// Написатьь программу, которая запрашивает у пользователя исходные данные,
// вычисляет результат по формуле ( 5 * x ) / ( y + x ) и печатает его на экране.

namespace Tyuiu.BardievaGA.Sprint1.Task1.V7
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
            Console.WriteLine("*Тема: Организация ввода/вывода в консольных приложениях                  *");
            Console.WriteLine("*Задание #1                                                               *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*вычисляет результат по формуле (5 * x)/(y + x) и печатает его на экране. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.BardievaGA.Sprint1.Task1.V7.Lib
            //в классе DataServise
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
