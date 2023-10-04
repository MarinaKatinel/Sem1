// Напишите программу , которая будет принимать на вход два числа и выводить, яляется ли второе число 
// кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления

//34,5 - не кратно, остаток 4
// 16, 4 -кратно

//void CheckMultiplicity(int num1, int num2)  //метод  void не возвращает число
//{
//    if(num1 % num2 == 0)
//    {
//        Console.WriteLine($"{num1}, {num2} -> кратно");
//    }
//    else
//    {
//        Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
//    }
//}

//Console.Write("Input first number:" );
//int num1 =Convert.ToInt32(Console.ReadLine());
//Console.Write("Input second number:" );
//int num2 =Convert.ToInt32(Console.ReadLine());

//CheckMultiplicity(num1,num2);

//Вторая задача:напишите программу, которая выврдит случайное число из отрезка {10, 99} и показывает 
//наибольшую цифру числа

//int BiggestDigit(int num)
//{
//    int ed = num % 10;
//    int dec = num / 10;
//    if(ed>dec)
//    {
//        return ed; // возвращает значение
//    }
//    else
//    {
//        return dec;
//    }
//}
//
//int num  = new Random().Next(10, 100); // метод Next передаем диапазон значений
//Console.WriteLine(num);
//int result = BiggestDigit(num);   *
//Console.WriteLine(result);        *       
//Console.WriteLine(BiggestDigit(num));

//Третья задача:напишите программу, которая выводит случайное трехзначное число и удаляет
//вторую цифру этого числа

//void exampleMethod(int num)
//{
//    int hund = num /100;
//    int ed = num %10;
//    Console.WriteLine($"{num} -> {hund *10 +ed}");
//}
//int num  =  new Random().Next(100, 1000);
//exampleMethod(num);

//Четвертая задача: напишите программу, которая принимает на вход число и проверяет кратно ли
//оно одновременно 7 и 23:

//bool CheckMultiplicity(int num)
//{
//    if(num%7 ==0 && num% 23 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine("Input number: ");
//int num =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{num} -> {CheckMultiplicity(num)}");


//ДЗ Задача : программа принимает на вход трехзначное число, и выводит вторую цифру этого числа

//void CheckMultiplicity(int num1)
//{
//    int hund = num1 /10; //56
//    int ed = hund %10; //6
//    Console.WriteLine($"{num1} -> {ed}");
//}
//Console.Write("Input number:" );
//int num1 =Convert.ToInt32(Console.ReadLine());
//CheckMultiplicity(num1);

//ДЗ 2 Задача: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


//3ДЗ Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//void searchWeekend(int num1)  //метод  void не возвращает число
//{
//    if(num1 >= 6)
//    {
//       Console.WriteLine($"{num1}-> this is off day ");
//    }
//   else
//    {
//        Console.WriteLine($"{num1}-> this is work day");
//    }
//}
//
//Console.Write("Input day of week:" );
//int num1 =Convert.ToInt32(Console.ReadLine());
//
//searchWeekend(num1);