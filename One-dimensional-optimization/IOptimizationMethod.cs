namespace One_dimensional_optimization
{
    public interface IOptimizationMethod
    {
        double FindExtreme(OptimizationTask task);
    }
}