/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
// int getNumber(string numX)
// {
//     Console.Write($"{numX}: ");
//     int numS = int.Parse(Console.ReadLine());
//     return numS;
// }
// int numA = getNumber("Какое число будем возводить в степень (Число А)");
// int numB = getNumber("В какую степень возведем число (Число В)");
// int getPeow()
// {
//     int i = 1;
//     int resultut = 1;
//     while (i <= numB)
//     {
//         resultut = resultut * numA;
//         i++;
//     }
//     return resultut;
// }
// int result = getPeow();
// //System.Console.WriteLine("You enter number A = " + numA);
// //System.Console.WriteLine("You enter number B = " + numB);
// System.Console.WriteLine($"Степень числа А будет равна {result}");


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
//int getNumber()
// {
//     Console.Write("Enter number: ");
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int numX = getNumber();

// int sumNumbers()
// {
//     int sum = 0;
//     if (numX <= 0)
//     {
//         numX = numX * -1;
//         while (numX >= 1)
//         {
//             sum = sum + numX%10;
//             numX = numX/10;
//         }
//     }
//     else
//     {
//         while (numX >= 1)
//         {
//             sum = sum + numX%10;
//             numX = numX/10;
//         }
//     } 

//     return sum;
// }

// int schet = sumNumbers();
// Console.WriteLine("Сумма цифр в числе равна " + schet);

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

// int[] getArray(int elNum, int min, int max)
// {
//     int[] array = new int[elNum];
//     Random randInt = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = randInt.Next(min, max + 1);
//     }
//     return array;
// }

// int[] che = getArray(8, -100, 100);
// Console.WriteLine(string.Join(" ", che));

