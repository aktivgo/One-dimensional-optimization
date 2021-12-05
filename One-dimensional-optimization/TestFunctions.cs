using System;

namespace One_dimensional_optimization
{
    public static class TestFunctions
    {
        #region x^4 + e^(-x)

        public static double TestFunc1GetValue(double x)
        {
            return Math.Pow(x, 4) + Math.Pow(Math.E, -x);
        }

        public static string TestFunc1ToString()
        {
            return "x^4 + e^(-x)";
        }

        public static double TestInverseFunc1GetValue(double x)
        {
            return -Math.Pow(x, 4) - Math.Pow(Math.E, -x);
        }

        #endregion

        #region x(1-x^2)^(1/3)

        public static double TestFunc2GetValue(double x)
        {
            return x * Math.Pow(1 - Math.Pow(x, 2), (double)1 / 3);
        }

        public static double TestInverseFunc2GetValue(double x)
        {
            return -x * Math.Pow(1 - Math.Pow(x, 2), (double)1 / 3);
        }

        public static string TestFunc2ToString()
        {
            return "x(1-x^2)^(1/3)";
        }

        #endregion
    }
}