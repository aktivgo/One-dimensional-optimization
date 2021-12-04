using System;
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
                    switch (ch)
                    {
                        case 0:
                            return;
                        case 1:
                        {
                            Console.Write("\nВведите название файла: ");
                            string fileName = Console.ReadLine();
                            CheckFileExist(fileName);
                            
                            PrintScanningMethod();
                        }
                            break;
                        default:
                            throw new Exception("\nПопробуйте ещё раз\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        
        private static void PrintMenu()
        {
            Console.WriteLine("1. Метод сканирования");
            Console.WriteLine("0. Выход");
        }

        private static void CheckFileExist(string fileName)
        {
            if (!File.Exists("data/" + fileName))
            {
                throw new Exception("\nФайла с названием \""  + fileName + "\" не существует\n");
            }
        }
        
        private static string ReadFromFile(string fileName)
        {
            FileStream stream = new FileStream("data/" + fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string textFromFile = reader.ReadToEnd();
            stream.Close();

            return textFromFile;
        }

        private static void PrintScanningMethod()
        {
            
        }
    }
}