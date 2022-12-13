// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int x = Input("Введите число: ");
int y = Input("Введите степень:");
System.Console.WriteLine($"{x} ^ {y} = {Rezult(x, y)}");




int Input(string text)
{
    Console.WriteLine(text);
    int i = Convert.ToInt32(System.Console.ReadLine());
    return i;
}


double Rezult(int number, int exponent)
{
    return Math.Pow(number, exponent);
}