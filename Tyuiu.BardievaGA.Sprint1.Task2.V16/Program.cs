using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.Task2.V16.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчеты: Известен радиус круга. Найти его периметр
//Радиус круга (целое число)
//Периметр круга (вещественное число)

namespace Tyuiu.BardievaGA.Sprint1.Task2.V16
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
            Console.WriteLine("*Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #16                                                              *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*Расчеты: Известен радиус круга. Найти его периметр                       *");
            Console.WriteLine("*Радиус круга (целое число)                                               *");
            Console.WriteLine("*Периметр круга (вещественное число)                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Периметр круга X = " + ds.CalculatePerimetrCircle(x));

            Console.ReadLine();
        }
    }
}
