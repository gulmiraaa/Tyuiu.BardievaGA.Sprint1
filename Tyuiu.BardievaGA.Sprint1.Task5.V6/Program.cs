using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task5.V6
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
            Console.WriteLine("*Тема: Преобразование типов и класс Convert                               *");
            Console.WriteLine("*Задание #5                                                               *");
            Console.WriteLine("*Вариант #6                                                               *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*какой день года соответствует какому дню недели.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день года: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine("День недели: " + res);

            Console.ReadLine();
        }
    }
}
