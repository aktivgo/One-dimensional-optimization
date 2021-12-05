using System;
using One_dimensional_optimization.Methods;

namespace One_dimensional_optimization
{
    public class OptimizationTask
    {
        private IOptimizationMethod _method;
        private readonly int _testFunc;
        public readonly string Purpose;
        public readonly double Start;
        public readonly double End;
        public readonly double E;

        public OptimizationTask(int testFunc, string purpose, double start, double end, double e)
        {
            validatePurpose(purpose);
            validateBorder(start, end);
            validateAccuracy(e);

            _testFunc = testFunc;
            Purpose = purpose;
            Start = start;
            End = end;
            E = e;
        }

        public void SetMethod(int method)
        {
            switch (method)
            {
                case 1:
                {
                    _method = new ScanningMethod();
                }
                    break;
                case 2:
                {
                    _method = new HalfDivisionMethod();
                }
                    break;
                case 3:
                {
                    _method = new GoldenRatioMethod();
                }
                    break;
            }
        }

        public double GetFuncValue(double x)
        {
            double result = 0;

            switch (_testFunc)
            {
                case 1:
                {
                    result = TestFunctions.TestFunc1GetValue(x);
                }
                    break;

                case -1:
                {
                    result = TestFunctions.TestInverseFunc1GetValue(x);
                }
                    break;

                case 2:
                {
                    result = TestFunctions.TestFunc2GetValue(x);
                }
                    break;

                case -2:
                {
                    result = TestFunctions.TestInverseFunc2GetValue(x);
                }
                    break;
            }

            return result;
        }

        public double GetExtreme()
        {
            return _method.FindExtreme(this);
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