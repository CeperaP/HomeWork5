// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size =new Random().Next(0,10000);

int[]array= new int[size];
int A=0;
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(100,1000);
    
    if (array[i]%2 ==0)
    {
        A++;
    }      
 }
    
 Console.WriteLine(A);