/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int n)
{
    int[]arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i<n; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
void PrintMassive(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[]arr = GetArray(size);

PrintMassive(arr);

int colChetDigit = 0;

for (int i = 0; i<arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        colChetDigit++;
    }
}
Console.WriteLine("Колличество четных терхзначных: " + colChetDigit);

