// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 int size = new Random().Next(20,40);

int[] array = new int[size];
int SumOdd = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-150, 151);
    if (i%2 ==1)
    {
        SumOdd+=array[i];
    }   
}
Console.WriteLine(SumOdd);