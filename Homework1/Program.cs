// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter start of interval: ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("Enter end of interval: ");
            double end = double.Parse(Console.ReadLine());
            Console.Write("Enter number of steps: ");
            int steps = int.Parse(Console.ReadLine());

            while (steps <= 0)
            {
                Console.Write("Enter number for steps higher than zero: ");
                steps = int.Parse(Console.ReadLine());
            }

            if (start > end)
            {
                double temp = start;
                start = end;
                end = temp;
            }

            Table table = new Table(start, end, steps);
            table.MakeTable();
        }
    }
}
