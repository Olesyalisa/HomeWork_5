/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int[] FillArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i<n; i++)
    {
        arr[i] = rnd.Next(-10, 100);
    }
    return arr;
}

void PrintMassive (int[]array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = FillArray(size);

PrintMassive(arr);

 int sum = 0;
for (int i = 0; i<arr.Length; i++)
{
    if (arr[i] % 2 != 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine("Сумма нечетных: " + sum);
