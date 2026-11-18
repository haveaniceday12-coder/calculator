namespace Calculator;

class Program
{
    static void Main()
    {
        bool keepCalculating;
        bool incorrectChoice;
        do
        {
            do
            {
                Console.WriteLine("Enter first number: ");
                string strFirstNumber = Console.ReadLine() ?? "";
                Console.WriteLine("Enter operator (+, - , *, /): ");
                string strOperator = Console.ReadLine() ?? "";
                Console.WriteLine("Enter second number: ");
                string strSecondNumber = Console.ReadLine() ?? "";

                if (double.TryParse(strFirstNumber, out double firstNumber) && double.TryParse(strSecondNumber, out double secondNumber))
                {   incorrectChoice = false;
                    if (strOperator == "+" || strOperator == "-" || strOperator == "*" || strOperator == "/")
                    {
                        double result = Calculate(firstNumber, secondNumber, strOperator);

                        Console.WriteLine($"{firstNumber} {strOperator} {secondNumber} = {result}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                        incorrectChoice = true;
                    }

                }
                else
                {
                    Console.WriteLine("ERROR, Enter a valid number or operator");
                    incorrectChoice = true;
                }
            } while (incorrectChoice == true);


            keepCalculating = AskForAnotherCalculation();
        }
        while (keepCalculating == true);

    }

    static double Calculate(double firstNumber, double secondNumber, string strOperator)
    {
        switch (strOperator)
        {
            case "+":
                return firstNumber + secondNumber;


            case "-":
                return firstNumber - secondNumber;


            case "*":
                return firstNumber * secondNumber;

            case "/":
                return firstNumber / secondNumber;

            default:
                return 0;

        }

    }

    static bool AskForAnotherCalculation()
    {


        Console.WriteLine("Do you want to do another calculation?");
        string playersChoice = Console.ReadLine() ?? "";
        playersChoice = playersChoice.ToLower();

        if (playersChoice == "yes")
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
