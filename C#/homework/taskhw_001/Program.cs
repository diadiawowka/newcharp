Console.Clear();
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num/10%10;

// Console.WriteLine(result);


// !!Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int index = 10;
// int div = num%index;
// int index = 1000;

// if (num < 100)
// {
// Console.WriteLine("третьей цифры нет");   
// }
// else if (num < 1000) 
// {
//     Console.WriteLine(div); // i t.d.
// }
//  else
//  {
//    Console.WriteLine("такой цифры нет "); 
//  }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num == 6)||(num == 7))
// {
// Console.WriteLine("да");
// }
// else
// {
// Console.WriteLine("нет");
// }


// Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.WriteLine("Enter a number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num/10000 == num%10 && num/10%10 == num/1000%10)

// Console.WriteLine("yes");
// else Console.WriteLine("no");

// int div5 = num%10;
// int div1 = num/10000;
// int div4 = num/10%10;
// int div2 = num/1000%10;

// if (div5==div1&&div4==div2) Console.WriteLine("да");
//  else Console.WriteLine("нет");

// Задача 19
// Console.Clear();
// int[] array = new int[5];
// Console.Write("Введите пятизначное число ");
// int num = Int32.Parse(Console.ReadLine());

// int rev = 0;
// while (num > 0)
// {
//     rev = rev * 10 + num%10;
//     num=num/10;

// }
// if(rev == num) Console.Write ("Введенное число является полиандром");
// else Console.Write ("Введенное число неявляется полиандром");





// Задача 22 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("ВВедите координаты");
// Console.Write("x1= ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1= ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z1= ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("x2= ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2= ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z2= ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
// result = Math.Round(result, 2);
// Console.WriteLine(result);

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// int res = 0; 
// while (x <= num)
// {
//     res = x*x*x;
// Console.WriteLine($"{x} -> {res}");
// x++;
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter a number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int x = 0;
int res = numB;
while (x <= numB)
{

    res = numA*numA;
    Console.WriteLine($"{x} -> {res}");
    x++;
}











// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]