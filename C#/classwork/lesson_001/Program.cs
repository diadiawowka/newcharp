Console.Clear();
// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.WriteLine("Enter a number");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a number");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)Console.WriteLine("quart1");
// if (x < 0 && y > 0)Console.WriteLine("quart2");
// if (x < 0 && y < 0)Console.WriteLine("quart3");
// if (x > 0 && y < 0)Console.WriteLine("quart4");


// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num < 1) || (num > 4))
// {
// Console.WriteLine("Некорректные данные");
// }
// if (num == 1)Console.WriteLine("x > 0, y > 0");
// if (num == 2)Console.WriteLine("x > 0, y < 0");
// if (num == 3)Console.WriteLine("x < 0, y < 0");
// if (num == 4)Console.WriteLine("x > 0, y < 0");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("ВВедите координаты двух точек на плоскости");
// Console.Write("x1= ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1= ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("x2= ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2= ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// double result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
// result = Math.Round(result, 2);
// Console.WriteLine(result);


// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("ВВедите число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x<=0) Console.WriteLine("число должно быть положительным");
// else
// {
// int[] n = new int[x];
// for (int i =0; i< n.Length; i++)
// {
// n[i] = (i+1)*(i+1);
// Console.Write(n[i]);
// if (i< n.Length-1) Console.Write(", ");
// }
// Console.WriteLine();