//Console.WriteLine("Введите число: ");
//int N = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Чётные числа от 1 до {N}:");
//for (int i = 2; i <= N; i += 2)
//{
//    Console.Write(i + " ,");
//}
//
//Console.WriteLine();

//Нахождение максимум из 9 чисел:

int Max(int arg1, int arg2, int arg3)
{
    int result =arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}

//int a1 = 155641;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 2356;
//int c2 = 33;
//int a3 = 13;
//int b3 = 23;
//int c3 = 313;  

//Массив:

int[] array = {1,2,3,44,5,68,7,8,9};

int max = Max(
    Max (array[0], array[1],array[2]),
    Max (array[3], array[4],array[5]),
    Max (array[6], array[7],array[8])
);
Console.WriteLine(max);

//int max1 = Max(a1, b1, c1);   Вторая правка
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

//if(b1 > max) max = b1;
//if(c1 > max) max = c1;
//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;
//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(c3 > max) max = c3;

//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

//Console.WriteLine(max);