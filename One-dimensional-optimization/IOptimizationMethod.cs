using System.Collections.Generic;
using One_dimensional_optimization.Tools;

namespace One_dimensional_optimization
{
    public interface IOptimizationMethod
    {
        Point FindExtremes(OptimizationTask task);
    }
}