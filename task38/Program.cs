// Задача 38: Задайте массив натуральных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int size = 20;
int[] array = new int[size];
int Difference = 0;
int Max = 1;
int Min = 1;

for (int i = 0; i < array.Length; i++)
{
     array [i]= new Random().Next(1,50);

    if (Max < array[i])
    {
        Max = array[i];
    }
    if (Min > array[i])
    {
        Min = array[i];
    }
}

Console.WriteLine($"Максимальное число: {Max}");
Console.WriteLine($"Минимальное число: {Min}");
Difference = Max - Min;
Console.WriteLine($"Разница: {Difference}");