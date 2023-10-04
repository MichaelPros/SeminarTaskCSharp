/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int GetNumber(string message)
{
    Console.Write($"{message}");
    int chislo = int.Parse(Console.ReadLine());
    return chislo;
}
int[] MasNumber(int Num)
{
    int[] array = new int[Num];
    if (Num == 1) return array;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Num;
        Num--;
    }
    return array;
}
int[] MasNumber1(int Num)
{
    int[] array = new int[Num];
    if (Num == 1) return array;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Num;
    }
    return MasNumber1(Num - 1);
}

int num = GetNumber("Enter number: ");
int[] array = MasNumber(num);
int[] array1 = MasNumber(num);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", array1));
//System.Console.WriteLine(num);

/*Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int M = GetNumber("Введите число, c которого начнется диапозон: ");
int N = GetNumber("Введите число, чем закончится диапозон: ");
int SumChisel(int M, int N)
{
    int sum = 0;
    while(M<=N)
    {
        sum = sum + M;
        M++;
    }
    return sum;
}
int summa = SumChisel(M, N);
System.Console.WriteLine(summa);
int[] MassChisel(int M, int N)
{
    int dlina = N - M + 1;
    int[] array = new int[dlina];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = M;
        M++;   
    }
    return array;
}
int SumChisel1(int[] array, int i)
{
    if (i>=array.Length) return 0;
    int sum = SumChisel1(array, i + 1);
    return array[i] + sum;

}
int[] testarray = MassChisel(M,N);
System.Console.WriteLine(string.Join(" ", testarray));
int summas = SumChisel1(testarray, 0);
System.Console.WriteLine(summas);




/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int n, int m)
{
  if (n == 0) 
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
int Zna4Akkerman = Akkerman(N, M);
System.Console.WriteLine(Zna4Akkerman);