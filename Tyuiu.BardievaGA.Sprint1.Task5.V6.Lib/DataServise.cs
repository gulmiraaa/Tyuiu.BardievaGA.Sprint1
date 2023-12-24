using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BardievaGA.Sprint1.Task5.V6.Lib
{
    public class DataServise : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int res = k % 7;
            return res;
        }
    }
}
