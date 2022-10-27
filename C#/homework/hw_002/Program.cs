// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void Printarray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]},");
//         }
//         Console.WriteLine();
//     }
// }
// void Result(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)
//         {
//             if (array[i, k] < array[i, k + 1]) 
//             {
//                 temp = array[i, k];
//                 array[i, k] = array[i, k + 1];
//                 array[i, k + 1] =  temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив упорядочянный по убыванию:");
// }
// Console.Clear();
// int[,] array = {{ 2, 4, 6, 9 },{3, 7, 2, 5},{1, 6, 3, 6},{1, 6, 3, 7}};
// Console.WriteLine("Двумерный массив:");
// Printarray(array);    
// Result(array);       
// Printarray(array);   

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}
void Sum(int [,] array)
{

    int stringsum = Int32.MaxValue;
    int indexstring = 0;
    for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum+ array[i, j];        
    }
    if (sum < stringsum)
    {
        stringsum = sum;
        indexstring++;
    }
}
Console.WriteLine($"Строка с наименьшей суммой Nr: {indexstring}, сумма = {stringsum}");
}

int[,] array = {{ 0, 4, 6, 0 },{3, 7, 2, 5},{1, 6, 3, 6},{1, 6, 3, 7}};
PrintArray(array);    
Sum(array);  