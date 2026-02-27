using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    internal class Table
    {
        #region Data members
        private double start;
        private double end;
        private int steps;
        #endregion

        #region Constructors
        public Table(double start, double end, int steps)
        {
            this.start = start;
            this.end = end;
            this.steps = steps;
        }
        #endregion

        #region Properies
        public double Start { get => start; }
        public double End { get => end; }
        public int Steps { get => steps; }
        #endregion

        #region Utility methods
        public void MakeTable()
        {
            double diff = ( end - start ) / steps;
            int counter = 0;

            for (int i = 0; i <= steps; i++)
            {
                double x = start + i * diff;
                Console.WriteLine($"{x:F4}\t{Function(x):F4}");

                counter++;
                if (counter % 20 == 0)
                {
                    Console.Write("Press return to continue ...");
                    Console.ReadLine();
                }
            }
        }

        private double Function(double x)
        {
            return Math.Pow((x - 2), 2) / (Math.Pow(x, 2) + 1);
        }
        #endregion
    }
}
