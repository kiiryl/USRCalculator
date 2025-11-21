using System;


namespace USRCalculator
{
    internal class Functions
    {
        HelperFunctions helpers = new HelperFunctions();
        public void StartMessage()
        {
            Console.WriteLine("\n=============================" +
                "\n======== КАЛЬКУЛЯТОР ========\n=============================\n");
            Console.WriteLine("1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n");
        }
        public string Calculate(int operation = 0)
        {
            if (operation == 4)
            {
                double a = helpers.TryGetDouble("число А");
                double b = helpers.TryGetDouble("число Б", checkZero: true);
                return Division(a, b);
            }
            else
            {
                double a = helpers.TryGetDouble("число А");
                double b = helpers.TryGetDouble("число Б");
                switch (operation)
                {
                    case 1:
                        return Addition(a, b);
                    case 2:
                        return Subtraction(a, b);
                    case 3:
                        return Multiplication(a, b);
                    default:
                        return "Ошибка выбора!!!";
                }
            }
        }
        public void ShowAnswer(string answer = "")
        {
            Console.WriteLine($"\nОтвет: {answer}\n");
        }
        public void ShowChoice(int operation)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine($"\n---- Сложение (А + Б)");
                    break;
                case 2:
                    Console.WriteLine($"\n---- Вычитание (А - Б)");
                    break;
                case 3:
                    Console.WriteLine($"\n---- Умножение (А * Б)");
                    break;
                case 4:
                    Console.WriteLine($"\n---- Деление (А / Б)");
                    break;
            }
        }

        // Операции
        public string Addition(double a, double b)
        {
            return $"{a + b}";
        }
        public string Subtraction(double a, double b)
        {
            return $"{a - b}";
        }
        public string Multiplication(double a, double b)
        {
            return $"{a * b}";
        }
        public string Division(double a, double b)
        {
            return $"{a / b}";
        }
    }
}
