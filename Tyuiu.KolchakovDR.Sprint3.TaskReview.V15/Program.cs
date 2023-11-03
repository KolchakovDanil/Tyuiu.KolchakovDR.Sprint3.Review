using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.TaskReview.V15.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.TaskReview.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Задание по спринту (SprintReview) #3",
                7,
                15,
                "Написать программу, которая выводит таблицу значений функции f(x) на промежутке [-5, 5] с шагом 1. При делении на ноль вернуть значение 0.");
            thg.printHeader();

            int start = -5;
            int stop = 5;
            int len = ds.GetMassFunction(start, stop).Length;
            double[] result = new double[len];
            result = ds.GetMassFunction(start, stop);

            Console.WriteLine("Начало шага = " + start);
            Console.WriteLine("Конец шага = " + stop);

            thg.printFooter();

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|      x      |     f(x)      |");
            Console.WriteLine("+-----------------------------+");

            for (int i = 0; i <= result.Length - 1; i++)
            {
                Console.WriteLine("|  {0, 5:d}      |    {1, 6:f2}     |", start, result[i]);
                start++;
            }
            Console.WriteLine("+-----------------------------+");
            Console.ReadKey();
        }
    }
}
