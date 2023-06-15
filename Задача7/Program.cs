/*Задача 7. Напишите программу, которая на вход принимает тёхзначное число 
и на выходе показывает последнюю цифру этого числа*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int N = int.Parse(Console.ReadLine());
int ostN = N % 10;
Console.WriteLine(ostN);