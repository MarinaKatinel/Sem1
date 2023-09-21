Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до {N}:");
for (int i = 2; i <= N; i += 2)
{
    Console.Write(i + " ,");
}

Console.WriteLine();
