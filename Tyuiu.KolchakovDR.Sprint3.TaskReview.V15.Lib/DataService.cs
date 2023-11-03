using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolchakovDR.Sprint3.TaskReview.V15.Lib
{
    public class DataService : ISprint3Task7V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double y;
            int len = (stopValue - startValue) + 1;
            double[] mass = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + (2 * x / 3) - (Math.Cos(x) * 4 * x)), 2);
                mass[count] = y;
                count++;
            }
            return mass;
        }
    }
}
