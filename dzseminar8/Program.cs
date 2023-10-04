/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int GetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int MatrixLine = 4, int MatrixColumn = 4)
{
    int[,] array = new int[MatrixLine, MatrixColumn];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SortMatrix(int[,] Matrix)
{
    int tempElem;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(1) - 1; k++)
            {

                if (Matrix[i, k] < Matrix[i, k + 1])
                {
                    tempElem = Matrix[i, k + 1];
                    Matrix[i, k + 1] = Matrix[i, k];
                    Matrix[i, k] = tempElem;
                }
            }
        }
    }
    return Matrix;
}
int MatrixLine = GetNumber("Введите количество строк матрицы: ");
int MatrixColumn = GetNumber("Введите количество столбцов матрицы: ");
int MatrixBack = GetNumber("Введите количество задних рядов матрицы: ");
int[,] Matrix = GetMatrix(MatrixLine, MatrixColumn);
//.WriteLine(MatrixLine);
//Console.WriteLine(MatrixColumn);
PrintMatrix(Matrix);
Console.WriteLine();
int[,] NewMatrix = SortMatrix(Matrix);
//PrintMatrix(NewMatrix);


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[] SumElemString(int[,] Matrix)
{
    int[] SumLine = new int[Matrix.GetLength(0)];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            SumLine[i] = SumLine[i] + Matrix[i, j];
        }
    }
    return SumLine;
}
//Console.WriteLine(string.Join(" ", SumElemString(Matrix)));
int MinSumElemString(int[] array)
{
    int MinElem = array[0];
    int NumberString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (MinElem > array[i])
        {
            MinElem = array[i];
            NumberString = i;
        }
    }
    return NumberString;
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumElemString(SumElemString(Matrix))} строка.");
/*Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] NewThirdMatrix(int Line = 2, int Column = 2, int Back = 2)
{
    Random rand = new Random();
    int[,,] Matrix = new int[Line, Column, Back];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
            {
                Matrix[i, j, k] = rand.Next(0, 10);
            }
        }
    }
    return Matrix;
}
void PrintNewMatrixThird(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] MatrixNewThird = NewThirdMatrix(MatrixLine, MatrixColumn, MatrixBack);
PrintNewMatrixThird(MatrixNewThird);

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
int k = 1;
int[,] QuardMatrix = new int[4, 4];
QuardMatrix[0, 0] = 0;
for (int i = 0; i < QuardMatrix.GetLength(0); i++)
{
    for (int j = 0; j < QuardMatrix.GetLength(1); j++)
    {
        if (i == 0) QuardMatrix[i, j] = QuardMatrix[i, j] + k;
        if (j == 3 && i == 1) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 3;
        if (j == 3 && i == 2) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 6;
        if (j == 3 && i == 3) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 9;
        if (j == 0 && i == 3) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 3;
        if (j == 1 && i == 3) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 5;
        if (j == 2 && i == 3) QuardMatrix[i, j] = QuardMatrix[i, j] + k - 7;
        if (j == 0 && i == 1) QuardMatrix[i, j] = QuardMatrix[i, j] + k + 7;
        if (j == 0 && i == 2) QuardMatrix[i, j] = QuardMatrix[i, j] + k +2;
        if (j == 1 && i == 1) QuardMatrix[i, j] = QuardMatrix[i, j] + k +7;
        if (j == 2 && i == 1) QuardMatrix[i, j] = QuardMatrix[i, j] + k +7;
        if (j == 2 && i == 2) QuardMatrix[i, j] = QuardMatrix[i, j] + k +4;
        if (j == 1 && i == 2) QuardMatrix[i, j] = QuardMatrix[i, j] + k +6;
        Console.Write(QuardMatrix[i, j] + "\t");
        k++;
    }
    System.Console.WriteLine();
}