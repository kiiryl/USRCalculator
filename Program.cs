using System;


namespace USRCalculator
{
    internal class Program
    {
        static HelperFunctions helpers = new HelperFunctions();
        static Functions func = new Functions();

        static void Main()
        {
            do Calculator();
            while (ShouldContinue());
        }
        static void Calculator()
        {
            func.StartMessage();
            int operation = helpers.TryGetInt("номер опреации", 1, 4);
            func.ShowChoice(operation);
            string answer = func.Calculate(operation);
            func.ShowAnswer(answer);
        }
        static bool ShouldContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить, \nнажмите Q для выхода.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Q) return false;
            else return true;
        }
    }

}
