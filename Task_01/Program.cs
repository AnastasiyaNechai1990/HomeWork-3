/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
int res = 0;
while (num1 > 0)
{
   res = res * 10 + num1 % 10; num1 /= 10;
}
if (num == res)
{
    Console.Write($"Число {num} -> палиндром");
}
else
{
    Console.Write($"Число {num} -> не является палиндромом");
}




