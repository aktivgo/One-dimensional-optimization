namespace One_dimensional_optimization.Methods
{
    public class ScanningWithVariableStepMethod : IOptimizationMethod
    {
        public double FindExtreme(OptimizationTask task)
        {
            int n = (int)((task.End - task.Start) / task.E);
            int h = (int)(task.End - task.Start) / 4;
            double x = task.Start;
            double min = task.GetFuncValue(task.Start);
            
            for (int i = 0; i < n; i++)
            {
                h /= 4;
                if(task.GetFuncValue(x + h) < min)
                {
                    while(task.GetFuncValue(x + h) < min)
                    {
                        min = task.GetFuncValue(x + h);
                        x += h;
                    }
                }
                else if(task.GetFuncValue(x - h) < min)
                {
                    while (task.GetFuncValue(x - h) < min)
                    {
                        min = task.GetFuncValue(x - h);
                        x -= h;
                    }
                }
            }

            return x;
        }
    }
}