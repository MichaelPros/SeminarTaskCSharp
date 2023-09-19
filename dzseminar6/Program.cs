/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/



// string[] getNum(string message)
// {
//     Console.Write($"{message}");
//     string mess = Console.ReadLine();
//     string[] numbers = mess.Split(new char[] { ' ' });
//     return numbers;
// }

// int[] mass(string[] getNum)
// {
//     int numb = 0;
//     int[] arr = new int[getNum.Length];
//     for (int i = 0; i < getNum.Length; i++)
//     {
//         numb = int.Parse(getNum[i]);
//         arr[i] = numb;
//     }
//     return arr;
// }

// int plusNumber(int[] mass)
// {
//     int sum = 0;
//     for (int i = 0; i < mass.Length; i++)
//     {
//         if (mass[i] > 0)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }


// string[] test = getNum("Щас введу: ");
// //System.Console.WriteLine(string.Join(" ", test));
// int[] testik = mass(test);
// System.Console.WriteLine(string.Join(" ", testik));
// int Summa = plusNumber(testik);
// System.Console.WriteLine("Количество положительных элементов " + Summa);

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// double GetNumber (string message)
// {
//     System.Console.WriteLine($"{message}");
//     double num = int.Parse(Console.ReadLine());
//     return num;
// }
// double k1 = GetNumber("ВВедите значение k1: ");
// double b1 = GetNumber("ВВедите значение b1: ");
// double k2 = GetNumber("ВВедите значение k2: ");
// double b2 = GetNumber("ВВедите значение b2: ");

// void getPoint()
// {
// double x = (b2 -b1)/(k1-k2);
// double y = k2*x + b2;
// double [] point = new double[2] {x , y};
// System.Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} ->" + "(" + string.Join("; ", point) + ")");
// }

// getPoint();