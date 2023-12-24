using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Важно! Следует к библиотеке кассов подключить файл tyuiu.cources.programming.interfaces.dll
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BardievaGA.Sprint1.Task0.V19.Lib
{
    public class DataService : ISprint1Task0V19
    {
        public double Calculate()
        {
            return 4 / 2 * 5 / (3 + 2) * 5;
        }
    }
}
