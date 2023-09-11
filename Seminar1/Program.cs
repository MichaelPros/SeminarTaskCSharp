/* Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

// Console.WriteLine("Enter number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.Write("number 1 > number 2. Max = ");
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.Write("Number 2 > Number 1. Max = ");
//     Console.WriteLine(num2);
// }

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

// Console.WriteLine("Enter number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num1);
// }
// else if (num2 > num1 && num2 > num3)
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num2);
// }
// else if (num1 == num2 && num1 > num3)
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num1);
// }
// else if (num1 == num3 && num1 > num2)
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.Write("Max = ");
//     Console.WriteLine(num3);
// }


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

// Console.WriteLine("Enter number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 % 2 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

// Console.WriteLine("Enter number; ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// if (num < 0)
// {
//     Console.WriteLine("Incorrect number");
// }
// else
// {while (index <= num)
//     {
//         if(index % 2 == 0)
//         {
//             Console.Write(index + " , ");
//         }
//         index = index + 1;
//     }
// }


/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// Console.WriteLine("Enter number; ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000)
// {
//     int num1 = num / 10;
//     int num2 = num1 % 10;
//     Console.WriteLine(num2);
// }
// else
// {
//     Console.WriteLine("Incorrect number");
// }

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else if (num < 1000)
// {
//     int num1 = num % 10;
//     Console.WriteLine(num1);
// }
// else
// {
//     while (num >= 1000)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine(num % 10);
// }

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Console.WriteLine("Enter number day of week");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 1 || num > 7)
// {
//     Console.WriteLine("Enter correkt day of week");
// }
// else
// {
//     if(num == 6 || num == 7)
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }


// }
//


//попробовал чужой код 


// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (num % 2 == 0)
// {
//     while (num != 0)
//     {num = num - 2;
//     Console.WriteLine(num);
//     }
// }
// else
// {
//     count = num - 1;
//     while(count != 0)
//     {
//         count = count - 2;
//         Console.Write(count + " ");
//     }

// }