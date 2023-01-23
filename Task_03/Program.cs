/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 
1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/* Напишите праграмму, которая принимает на вход число(N) и выдает таблицу квадратов 
чисел от 1 до N. Пример:
5 -> 1, 4, 9, 16, 25
2 -> 1, 4 */

Console.Clear();
Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
// Вариант 1
//Console.Write($"{Math.Pow(count, 2)}");
//count++;

while (count <= number)
{
    Console.Write($"{Math.Pow(count, 3)}");
    if (count != number) Console.Write(", "); //Второй вариант того что бы после последней цифра небыло запятой
    count++;
}