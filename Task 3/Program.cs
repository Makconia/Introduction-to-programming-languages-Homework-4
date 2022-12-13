//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
 
System.Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение числа массива:");
int MinNumber = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение числа массива:");
int MaxNumber = Convert.ToInt32(System.Console.ReadLine());
 
int[] array = OutputMass(size, MinNumber, MaxNumber);


 
int[] OutputMass(int size, int left, int right)
{
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rand.Next (left, right+1);
}
System.Console.WriteLine();
System.Console.WriteLine(string.Join(" | ", array)); 
return array;
}