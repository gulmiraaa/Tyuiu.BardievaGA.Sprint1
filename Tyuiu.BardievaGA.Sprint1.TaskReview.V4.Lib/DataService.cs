using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BardievaGA.Sprint1.TaskReview.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round(Math.Log((y - Math.Sqrt(x)) * (x - (y / (x + (Math.Pow(x, 2) / 4))))), 3);
            return z;

        }
    }
}
