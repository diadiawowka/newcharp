// Пример - нахождение макс переменных
// Console.Clear();
// int Max(int arg1, int arg2, int arg3) //строки 3-9, функция для 3вар
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

// int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

// Console.WriteLine(max);


// работа с массивом
// Console.Clear();
// int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
// array[0] = 12;
// Console.WriteLine(array[0]);


// 2-й пример
// Console.Clear();
// int Max(int arg1, int arg2, int arg3) 
// {
//     int result = arg1;
//     if(arg2> result) result = arg2;
//     if(arg3> result) result = arg3;
//     return result;
// }
// int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19 };

// int result = Max(
// Max(array[0], array[1], array[2]),
// Max(array[3], array[4], array[5]),
// Max(array[6], array[7], array[8] )
// );
// Console.WriteLine(result);


// пример нахождения эллемента массива
// int[] array = { 1, 21, 31, 41, 19, 15, 61, 17, 18, 19 };

// int n = array.Length;
// int find = 19;

// int index = 0;

// while (index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
    
//     index++;
// }

