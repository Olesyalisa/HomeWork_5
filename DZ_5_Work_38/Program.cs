/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] FillArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i<size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble()*100);
    }
    return arr;
}

void PrintMass (double[]array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] arr = FillArray(size);

PrintMass(arr);


double max = arr[0];
double min = arr[0];
for (int i = 0; i<arr.Length; i++)
{
    if (max<arr[i]) max = arr[i];
    if (min>arr[i]) min = arr[i];
}
Console.WriteLine("Разница между min & max = " + (max-min));
