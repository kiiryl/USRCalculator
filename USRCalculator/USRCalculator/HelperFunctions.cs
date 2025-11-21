using System;


namespace USRCalculator
{
    internal class HelperFunctions
    {
        public int TryGetInt(string message = "", int min = -1500000000, int max = 1500000000)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите {message}:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num < min || num > max)
                    {
                        throw new ArgumentException();
                    }
                    return num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОшибка ввода: введено не число!!!\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nОшибка ввода: число слишком большое!!!.\n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nОшибка ввода: число вне допустимого диапазона!!!\n");
                }
            }
        }
        public double TryGetDouble(string message = "", double min = -5e45, double max = 5e45, bool checkZero = false)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите {message}:");
                    double dbl = Convert.ToDouble(Console.ReadLine());
                    if (dbl < min || dbl > max)
                    {
                        throw new ArgumentException("число вне допустимого диапазона!!!");
                    }
                    if (checkZero && dbl == 0)
                    {
                        throw new ArgumentException("делить на ноль не будем)");
                    }
                    return dbl;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОшибка ввода: введено не число!!!\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nОшибка ввода: число слишком большое!!!.\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\nОшибка ввода: {ex.Message}\n");
                }
            }
        }
        public string TryGetString(string message = "", int min = 0, int max = 500)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите {message}:");
                    string str = Console.ReadLine();
                    if (str.Length < min || str.Length > max)
                    {
                        throw new ArgumentException();
                    }
                    return str;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nОшибка ввода: Сообщение слишком длинное!!!.\n");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nОшибка ввода: Сообщение слишком длинное!!!\n");
                }
            }
        }

    }
}
