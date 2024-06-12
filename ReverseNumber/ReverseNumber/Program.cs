Console.WriteLine("Hello in program ReverseNumber!");
Console.WriteLine();

string number;
while (true)
{
    Console.WriteLine($"Enter a number:");
    number = Console.ReadLine();

    if (IsDigitsOnly(number))
    {
        break;
    }
    else
    {
        Console.WriteLine($"Invalid input {number}. Please enter a valid number.");
    }
}
List<char> digits = new List<char>();
foreach (char digit in number)
{
    digits.Add(digit);
}

digits.Reverse();

string newNumber = new string(digits.ToArray());

Console.WriteLine();
Console.WriteLine($"Reversed number: {newNumber}");

static bool IsDigitsOnly(string number)
{
    foreach (char digit in number)
    {
        if (digit < '0' || digit > '9')
        {
            return false;
        }
    }
    return true;
}