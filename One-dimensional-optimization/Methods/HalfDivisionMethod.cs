using System;

namespace One_dimensional_optimization.Methods
{
    public class HalfDivisionMethod : IOptimizationMethod
    {
        public double FindExtreme(OptimizationTask task)
        {
            double middle = (task.Start + task.End) / 2;
            double left = middle - task.E / 2;
            double right = middle + task.E / 2;

            double start = task.Start;
            double end = task.End;

            while (Math.Abs(start - end) / 2 > task.E)
            {
                if (task.GetFuncValue(left) < task.GetFuncValue(right))
                {
                    end = right;
                }
                else
                {
                    start = left;
                }

                middle = (start + end) / 2;
                left = middle - task.E / 2;
                right = middle + task.E / 2;
            }

            return (start + end) / 2;
        }
    }
}