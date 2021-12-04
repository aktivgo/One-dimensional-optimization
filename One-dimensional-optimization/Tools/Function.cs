using System;
using System.Collections.Generic;
using System.Linq;

namespace One_dimensional_optimization.Tools
{
    public class Function
    {
        private readonly List<string> elements;
        private readonly List<string> signs;
        
        public Function(string function)
        {
            elements = ParseElements(function);
            signs = ParseSigns(function);

            if (elements.Count != signs.Count + 1)
            {
                throw new Exception("Функция некорректна");
            }
        }

        private List<string> ParseElements(string function)
        {
            char[] separator = { '+', '-' };
            return function.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private List<string> ParseSigns(string function)
        {
            return (from character in function where character == '+' || character == '-' select character.ToString()).ToList();
        }

        public double GetValue(double x)
        {
            double result = 0;

            foreach (var element in elements)
            {
                
            }

            return result;
        }
    }
}