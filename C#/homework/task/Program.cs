
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите число ");
// string N = Console.ReadLine();
// Console.Write(N.Length);


// Задача 10: 2-й вар

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num/10%10;

// Console.WriteLine(result);


//задача 30
// int[] num = new int [8];
// int index = 0;
// while(index < 8)
// {
//     num[index] = new Random().Next(0,2);
//     Console.Write($" {num[index]}, ");
//     index ++;
// }


// Задача На вход число,на выхот чётное или нечётное(исправить!!)

// Console.Write("type number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num/2;

// if (result == num/2)
// {
//     Console.Write("true");
// }
// else
// {
//     Console.Write("false");
// }


// Задача Нхождение максимального
// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);


// Пример - сумма 2-ч рандомных чисел

// int numberA = new Random().Next(1, 10); // 123..
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10); // 123..
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(numberA + numberB);


// Пример - приветствия пользователя

// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();

// if(username.ToLower() == "андрей")
// {
//     Console.WriteLine("Программисту пулий!!!");
// }
// else
// {
//     Console.Write("Норок - Шнурок! ");
//     Console.WriteLine(username);
// }


// Пример с курсором

// Console.Clear();
// //Console.SetCursorPosition(10, 4);
// //Console.WriteLine("+");

// int xa = 1, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");


// Задача - на вводе 2 числа на выводе макс

// Console.Write("first number ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("second number ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2)
// {
//     Console.WriteLine(number1);
// }
// else
// {
//     Console.WriteLine(number2);
// }

// Задача - на вводе 3 числа на выводе макс

// Console.Write("first number ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("second number ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("third number ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;

// if(number2 > max) max = number2;
// if(number3 > max) max = number3;

// Console.Write("max = ");
// Console.WriteLine(max);


// Пример - нахождение макс переменных строки 3-9, функция для 3вар
// Console.Clear();
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2> result) result = arg2;
//     if(arg3> result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 333;

// первый вариант закоментить не нужный

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Второй варивнт закоментить не нужный
// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1, max2, max3);

// третий вариант закоментить не нужный
// int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

// Console.WriteLine(max);