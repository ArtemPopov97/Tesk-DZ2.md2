// Задача 1: Напишите программу,которая принимает на     Пример: 456->5
// вход трёхзначное число и на выходе показывает                 782->8
// вторую цифру этого числа.                                     918->1


System.Console.Write("Введите число : ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = NumberA / 10 % 10;

int result = (NumberB);
Console.WriteLine($"Результат: {result}");