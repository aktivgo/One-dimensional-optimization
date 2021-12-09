namespace One_dimensional_optimization.Methods
{
    public class ScanningWithVariableStepMethod : IOptimizationMethod
    {
        public double FindExtreme(OptimizationTask task)
        {
            int n = (int)((task.End - task.Start) / task.E);
            //double h = (task.End - task.Start) / 4;
            double h = (task.End - task.Start) / 4;
            double x = task.Start;
            double min = task.GetFuncValue(task.Start);
            
            for (int i = 0; i < n; i++)
            {
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
                h /= 4;
            }

            return x;
        }
    }
}