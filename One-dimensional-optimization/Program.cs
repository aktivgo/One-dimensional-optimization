﻿using System;
using System.IO;

namespace One_dimensional_optimization
{
    internal static class Program
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    PrintMenu();
                    Console.Write("Выберите пункт меню: ");
                    var ch = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    if (ch != 0) PrintTestFunctions();

                    switch (ch)
                    {
                        case 0:
                            return;
                        case 1:
                        {
                            ProcessTask(1);
                        }
                            break;
                        case 2:
                        {
                            ProcessTask(2);
                        }
                            break;
                        case 3:
                        {
                            ProcessTask(3);
                        }
                            break;
                        default:
                            throw new Exception("\nПопробуйте ещё раз\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n");
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Метод сканирования");
            Console.WriteLine("2. Метод половинного деления");
            Console.WriteLine("3. Метод золотого сечения");
            Console.WriteLine("0. Выход");
        }

        private static void PrintTestFunctions()
        {
            Console.WriteLine("\nТестовые функции: ");
            Console.WriteLine("1. " + TestFunctions.TestFunc1ToString());
            Console.WriteLine("2. " + TestFunctions.TestFunc2ToString());
        }

        private static void ProcessTask(int ch)
        {
            OptimizationTask task = CreateTask();
            task.SetMethod(ch);

            PrintResult(task);
        }

        private static OptimizationTask CreateTask()
        {
            Console.Write("\nВведите номер тестовой функции: ");
            int func = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Введите цель(min/max): ");
            string purpose = Console.ReadLine() ?? string.Empty;

            if (purpose == "max")
            {
                func = -func;
            }

            Console.Write("Введите начало границы: ");
            double start = double.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Введите конец границы: ");
            double end = double.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Введите погрешность: ");
            double e = double.Parse(Console.ReadLine() ?? string.Empty);

            return new OptimizationTask(func, purpose, start, end, e);
        }

        private static void PrintResult(OptimizationTask task)
        {
            double x = task.GetExtreme();
            double f = task.GetFuncValue(x);
            Console.WriteLine("\nX" + task.Purpose + " = " + x + " +- " + task.E + "\nF(x) = " + f + "\n");
        }
    }
}