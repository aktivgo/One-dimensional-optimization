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
            double x1 = end - (end - start) / t;
            double x2 = start + (end - start) / t;

            while ((end - start) / 2 > task.E)
            {
                if (task.GetFuncValue(x1) > task.GetFuncValue(x2))
                {
                    start = x1;
                    x1 = x2;
                    x2 = end - (x1 - start);
                }
                else
                {
                    end = x2;
                    x2 = x1;
                    x1 = start + end - x2;
                }
            }

            return (start + end) / 2;
        }
    }
}