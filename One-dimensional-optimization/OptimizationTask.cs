using System;
using One_dimensional_optimization.Tools;

namespace One_dimensional_optimization
{
    public class OptimizationTask
    {
        private readonly Function func;
        private string purpose;
        private double start;
        private double end;
        private double e;

        public OptimizationTask(Function func, string purpose, double start, double end, double e)
        {
            validatePurpose(purpose);
            validateBorder(start, end);
            validateAccuracy(e);

            this.func = func;
            this.purpose = purpose;
            this.start = start;
            this.end = end;
            this.e = e;
        }

        public double GetFunctionValue(double x)
        {
            return func.GetValue(x);
        }

        private void validatePurpose(string purpose)
        {
            if (purpose != "min" && purpose != "max")
            {
                throw new ArgumentException("Некорректное значение цели");
            }
        }

        private void validateBorder(double start, double end)
        {
            if (start < 0 || end <= start)
            {
                throw new ArgumentException("Некорректное значение границ");
            }
        }

        private void validateAccuracy(double e)
        {
            if (e < 0)
            {
                throw new ArgumentException("Неккоректное значение точности");
            }
        }
    }
}