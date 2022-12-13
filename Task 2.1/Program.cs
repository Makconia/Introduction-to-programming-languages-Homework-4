// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


string number = inputNumber();
System.Console.WriteLine($"Сумма цифр в числе {number} = {SumOfDigits(number)}");

string inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    return text;
}

 
int SumOfDigits(string text)
{
    int sum = 0;
    for (int i = 0; i < text.Length; i++)
    {
        sum += Convert.ToInt32(Convert.ToString(text[i]));
    }
    return sum;
}