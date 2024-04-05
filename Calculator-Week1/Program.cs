using Calculator_Week1;
using System.Data;
using System.Xml.Serialization;
Calculator calculator = new Calculator();
Console.WriteLine("------------------------");
Console.WriteLine("Calculator");
bool calculate = true;
while (calculate)
{
    Console.WriteLine(@"Choose one of the options:
a - Add
s - Subtract
m - Multiply
q - Quit");
    Console.WriteLine("------------------------");
    string? choice;
    do
    {
        Console.Write("Enter your option: ");
        choice = Console.ReadLine();

    }
    while (string.IsNullOrEmpty(choice) || !(choice == "a" || choice == "s" || choice == "m" || choice == "q"));
    int firstNumber;
    int secondNumber;
    switch (choice)
    {
        case "a":
            firstNumber = GetNum("first");
            secondNumber = GetNum("second");
            Console.WriteLine($"{firstNumber} + {secondNumber} == {calculator.Add(firstNumber, secondNumber)}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            break;
        case "s":
            firstNumber = GetNum("first");
            secondNumber = GetNum("second");
            Console.WriteLine($"{firstNumber} - {secondNumber} == {calculator.Subtract(firstNumber, secondNumber)}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            break;
        case "m":
            firstNumber = GetNum("first");
            secondNumber = GetNum("second");
            Console.WriteLine($"{firstNumber} * {secondNumber} == {calculator.Multiply(firstNumber, secondNumber)}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            break;
        case "q":
            calculate = false;
            break;
        default:
            break;

    }
}

static int GetNum(string str)
{
    Console.Write($"Enter {str} number: ");         
    string? num = Console.ReadLine();
    int number;
    while (!int.TryParse(num, out number))
    {
        Console.Write("Invalid Input. Try Again: ");
        num = Console.ReadLine();
    }
    return number;
}


