namespace One_dimensional_optimization.Methods
{
    public class ScanningMethod : IOptimizationMethod
    {
        public double FindExtreme(OptimizationTask task)
        {
            for (double x = task.Start; x <= task.End; x += task.E)
            {
                if (task.GetFuncValue(x + task.E) > task.GetFuncValue(x))
                {
                    return x;
                }
            }

            return 0;
        }
    }
}