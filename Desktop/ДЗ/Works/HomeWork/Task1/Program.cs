﻿/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void ShowNums(int n)
{
    if (n >= 1)
    {
        System.Console.Write(n + " ");
        ShowNums(n-1);        
    }
}
ShowNums(8);
