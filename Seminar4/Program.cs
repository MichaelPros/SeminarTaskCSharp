int GetMessage(string message)
{
    Console.Write($"Enter number {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}



int GetSum(int num)
{
    int Sum = 0;
    for (int i = 0; i <= num; i++)
    {
       Sum = Sum + i;
       Console.Write(Sum + " "); 
    }
    Console.WriteLine();
    return Sum;
}

int numA = GetMessage("A");
Console.WriteLine(numA);
Console.WriteLine();
int numB = GetSum(numA);
Console.WriteLine(numB);