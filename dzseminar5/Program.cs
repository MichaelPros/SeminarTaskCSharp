/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
// int[] getArray(int elNum, int minNum, int maxNum)
// {
//     int[] array = new int[elNum];
//     Random randInt = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = randInt.Next(minNum, maxNum + 1);
//     }
//     return array;
// }
// int[] che = getArray(10, 100, 999);
// System.Console.WriteLine(string.Join(" ", che));

// int sumElemNumber(int[] mas) // Количество положительных элементов в массиве..
// {   
//     int sum = 0;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i]%2 == 0)
//         sum++;
//     }
//     return sum;
// }
// int sumElem = sumElemNumber(che);
// System.Console.WriteLine("Количество положительных элементов в массиве равна: " + sumElem);

// int sumEvenNumber(int[] mas) // Cумма всех положительных чисел в массиве.. 
// {   
//     int sum = 0;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i]%2 == 0)
//         sum += mas[i];
//     }
//     return sum;
// }
// int sumNum = sumEvenNumber(che);
// System.Console.WriteLine("Сумма положительных элементов в массиве равна: " + sumNum);


/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
// int[] getRandomArray(int elNum)
// {
//     int[] array = new int[elNum];
//     Random randInt = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = randInt.Next(-100, 101);
//     }
//     return array;
// }


// int sumOddNumber(int[] masRand)
// {
//     int sum = 0;
//     for (int i = 1; i < masRand.Length; i++)
//     {
//         if (i%2 == 1) 
//         {
//             sum+=masRand[i];
//             i++; // Можно было не делать проверку if,а написать i = i + 2 или i+=2
//         }
//     }
//     return sum;
// }

// int[] che1 = getRandomArray(12);
// System.Console.WriteLine(string.Join(" ", che1));
// int sumSum = sumOddNumber(che1);
// System.Console.WriteLine(sumSum);


/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

// double[] getDoubleArray(int numInt)
// {
//     Console.Write("Введите длину массива: ");
//     numInt = int.Parse(Console.ReadLine());
//     double[] array = new double[numInt];
//     Random numD = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToDouble(numD.Next(-10000, 10000) * 0.01);
//     }
//     return array;
// }

// double[] massiv = getDoubleArray(10);
// Console.WriteLine(string.Join(" ", massiv));

// double minElem(double[] masik)
// {
//     double min = masik[0];
//     for (int i = 0; i < masik.Length; i++)
//     {
//         if (min > masik[i])
//         {
//             min = masik[i];
//         }
//     }
//     return min;
// }

// double chislo = minElem(massiv);
// Console.WriteLine("Минимальный элемент в массиве равен: " + chislo);

// double maxElem(double[] masik)
// {
//     double max = masik[0];
//     for (int i = 0; i < masik.Length; i++)
//     {
//         if (max < masik[i])
//         {
//             max = masik[i];
//         }
//     }
//     return max;
// }

// double chisla = maxElem(massiv);
// Console.WriteLine("Максимальный элемент в массиве равен: " + chisla);

// void raznicaChisel()
// {
//     double raznica = chisla - chislo;
//     Console.WriteLine("Разница чисел равна: " + raznica);
// }

// raznicaChisel();