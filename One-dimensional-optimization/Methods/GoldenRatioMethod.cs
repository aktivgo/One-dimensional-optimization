using System;

namespace One_dimensional_optimization.Methods
{
    public class GoldenRatioMethod : IOptimizationMethod
    {
        public double FindExtreme(OptimizationTask task)
        {
            double start = task.Start;
            double end = task.End;

            double t = (1 + Math.Sqrt(5)) / 2;
            //double t = 1.618;

            while (end - start >= task.E)
            {
                double c = end - (end - start) / t;
                double d = start + (end - start) / t;
                
                if (task.GetFuncValue(c) < task.GetFuncValue(d))
                {
                    end = d;
                }
                else
                {
                    start = c;
                }
            }

            return (start + end) / 2;
        }
    }
}