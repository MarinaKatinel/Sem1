/* Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max: {num1}; min: {num2}");
}
else
{
    Console.WriteLine($"max: {num2}; min:{num1}");
} */
int FindSumNums (int m, int n);
{
    if (m != n)
    {
        if(m > n)
        {
            FindSumNums(n-1, n);
            System.Console.Write(m + " ");
        }
        else
        {
            FindSumNums(m, n-1);
            System.Console.Write(n + " ");
        }
    }
    else System.Console.Write(m + " ");
}
FindSumNums(5, 10);
