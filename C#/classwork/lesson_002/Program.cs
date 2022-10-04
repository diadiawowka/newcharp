Console.Clear();

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] Array = new int[12];
// int i = 0;
// int neg = 0;
// int poz = 0;

// while (i<12)

// {
//     Array[i] = new Random().Next(-9,10);
//     Console.Write({i});
//     if(Array[i]<0) neg += Array[i];
//     else poz += Array[i];
//     i++;
// }


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] Array = new int[4];
// int i = 0;
// int neg = 0;
// int poz = 0;
// int max = 0;
// while (i<4)

// {
//     Array[i] = new Random().Next(-4,5);
//     Console.WriteLine($"{Array[i]}");
//     if (Array[i]>max);
//     Array[i] = max;
//     i++;
// }




// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] Array = new int[12];
// int i = 0;
// int neg = 0;
// int poz = 0;
// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (i<12)

// {
//     Array[i] = new Random().Next(0,10);
//     if(Array[i] == num); 
//     Console.Write("yes");
     
//     else
  

// Console.Write("no");
//  i++;}


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// пример двумерных массивов
// int[,] xx = {{1, 2, 3, 4, 5},{6, 7, 8, 9, 0}};

// for(int i = 0; i < xx.GetLength(0); i++)
// {
//     for (int j = 0; j < xx.GetLength(1); j++)
//     {
//         Console.Write($" {xx[i,j]}");
//     }
// }
// Console.Write();





// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;

//     }

// }
// void PrintArray(int[]col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }

// int[] array = new int [10];

// FillArray(array);
// PrintArray(array);
// int i = array[0];
// int t = 0;
// for (int count = 0; count < array.Length / 2; count++ )
// {
//     t = array[count];
//     array[count] = array[array.Length -1 - count];
//     array[array.Length -1 - count] = t;
// }
// Console.WriteLine();
// PrintArray(array);


// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.Write("Enter a number A: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number B: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if ((num1 < num2 + num3)&&(num2 < num1 + num3)&&(num3 < num1 + num2))
// {
// Console.WriteLine("yes");
// }


// <aside>
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// </aside>


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите десятичное число");
// int a = Convert.ToInt32(Console.ReadLine());
// int x = a % 2;
// a /= 2;
// int i = 10;
// while (a > 0)
// {
//     x = x + (a % 2) * i;
//     a /= 2;
//     i *= 10;
// }
// Console.WriteLine(x);




// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите размер массива");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[k];
// a[0] = 0;
// a[1] = 1;
// for (int i = 2; i < a.Length; i++)
// {
//     a[i] = a[i - 1] + a[i - 2];
// }
// void print_array(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         Console.Write($"{a[i]} ");
//     }
//     Console.WriteLine();
// }
// print_array(a);


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] new_arr(int k)
// {
//     int[] a = new int[k];
//     for (int i = 0; i < k; i++)
//     {
//         a[i] = new Random().Next(1, 100);
//         Console.Write(a[i] + " ");
//     }
//     Console.WriteLine();
//     return a;
// }
// Console.WriteLine("Введите размер массива");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] a = new_arr(k);
// int[] b = new int[k];
// for (int i = 0; i < k; i++)
// {
//     b[i] = a[i];
// }
// void print_array(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         Console.Write($"{a[i]} ");
//     }
//     Console.WriteLine();
// }
// print_array(b);
